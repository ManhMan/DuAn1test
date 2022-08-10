using _1.DAL.Entities;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _3._Presentation
{
    public partial class FrmSanPham : Form
    {
        public IQLProductServices _IQLProductServices;
        public IQLProducerServices _IQLProducerServices;
        public ICategoryService _CategoryrServices;
        
        public Product _product;
        string linkavatar ="";

        public FrmSanPham()
        {
            InitializeComponent();
            _product = new Product();
            _IQLProductServices = new QLProductServices();
            _IQLProducerServices = new QLProducerServises();
            _CategoryrServices = new CategoryService();
            rd_kd.Checked = true;
            this.CenterToScreen();
            LoadData();
            LoadLoaiHang();
            LoadNhaSanXuat();

        }
        public void LoadNhaSanXuat()
        {
            var nsx = _IQLProducerServices.GetProducerFromDB();
            foreach(var item in nsx)
            {
                cbb_nhasanxuat.Items.Add(item.Name);
            }
        }
        public void LoadLoaiHang()
        {
            var lh = _CategoryrServices.GetCategoryFromDB();
            foreach (var item in lh)
            {
                cbb_loaihang.Items.Add(item.Name);
            }
        }
        public void LoadData()
        {
            dtgv_frmSP.ColumnCount = 9;
            dtgv_frmSP.Columns[0].Name = "Mã SP";
            dtgv_frmSP.Columns[1].Name = "Tên SP";
            dtgv_frmSP.Columns[2].Name = "Loại SP";
            dtgv_frmSP.Columns[3].Name = "Nhà sản xuất";
            dtgv_frmSP.Columns[4].Name = "Số lượng";
            dtgv_frmSP.Columns[5].Name = "Giá nhập";
            dtgv_frmSP.Columns[6].Name = "Giá bán";
            dtgv_frmSP.Columns[7].Name = "Trạng thái";
            dtgv_frmSP.Columns[8].Name = "Ghi chú";
            var data = (from a in _IQLProductServices.GetProductFromDB()
                        join b in _IQLProducerServices.GetProducerFromDB() on a.ProducerID equals b.ID
                        join c in _CategoryrServices.GetCategoryFromDB() on a.CategoryID equals c.ID
                        select new ProductVm
                        {
                            Id = a.MaSp,
                            Name = a.Name,
                            ProducerName = b.Name,
                            CategoryName = c.Name,
                            Stock = a.Stock,
                            OriginalPrice = a.OriginalPrice,
                            Price = a.Price,
                            Status = a.Status == true ? "Kinh doanh" : "Ngưng kinh doang",
                            Note = a.Note
                        }).ToList();

            foreach (var item in data)
            {
                dtgv_frmSP.Rows.Add(item.Id, item.Name, item.CategoryName, item.ProducerName, item.Stock, item.OriginalPrice, item.Price, item.Status, item.Note);
            }
            //dtgv_frmSP.DataSource = _IQLProductServices.ShowProduct();
            //foreach (var item in _IQLProductServices.ShowProduct())
            //{
            //    dtgv_frmSP.Rows.Add(item.Id, item.Name, item.ProducerName, item.Price, item.OriginalPrice, item.DateCreated, item.OriginalPrice, item.Note);
            //}

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool checksp = true;
            var sp = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.MaSp == tbt_maSP.Text);
            if(sp != null) { checksp= false;}
            var tsp = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.Name == tbt_maSP.Text);
            if (sp != null) { checksp = false; }
            int gn;
            if (!int.TryParse(tbt_gianhap.Text, out gn))
            {
                checksp = false;
            }
            else
            {
                if (gn < 0) { checksp = false; }
            }
            int gb;
            if (!int.TryParse(tbt_giaban.Text, out gb)){
                checksp = false;
            }
            else
            {
                if (gb < gn) { checksp = false; }
            }
            int sl;
            if (!int.TryParse(tbt_giaban.Text, out sl))
            {
                checksp = false;
            }
            else
            {
                if (sl < 0) { checksp = false; }
            }
            if(cbb_nhasanxuat.Text == null)
            {
                checksp = false;
            }
            if(cbb_loaihang.Text == null) checksp = false;
            if(linkavatar =="") checksp = false;
            if(checksp == false)
            {
                MessageBox.Show("Có gì đó sai sai", "Cảnh báo");
            }
            else
            {
                _product.MaSp = tbt_maSP.Text;
                _product.Name = tb_tensp.Text;
                _product.OriginalPrice = Convert.ToInt32(tbt_gianhap.Text);
                _product.Price = Convert.ToInt32(tbt_giaban.Text);
                _product.Stock = Convert.ToInt32(tbt_stock.Text);
                _product.ProducerID = cbb_nhasanxuat.SelectedIndex + 1;
                _product.CategoryID = cbb_loaihang.SelectedIndex + 1;
                _product.DateCreated = DateTime.Now;
                _product.LinkImage = linkavatar;
                _product.Note = tb_ghichu.Text;
                _product.Status = rd_kd.Checked == true ? true : false;
                _IQLProductServices.AddProduct(_product);
                LoadData();
                

            }


        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbb_listcamera.Items.Add(device.Name);
            }
            cbb_listcamera.SelectedIndex = 1;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_listcamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                tbt_maSP.Invoke(new MethodInvoker(delegate { tbt_maSP.Text = result.ToString(); }));
            }
            pictureBox1.Image = bitmap;
        }

        private void FrmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        

        private void pcb_anhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (pcb_anhSP.Image != null)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn đổi ảnh không", "Some tite", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        pcb_anhSP.Image = Image.FromFile(op.FileName);
                        pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        linkavatar = op.FileName;
                    }

                }
            }
            else
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pcb_anhSP.Image = Image.FromFile(op.FileName);
                    pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    linkavatar = op.FileName;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    tbt_maSP.Text = decoded;
                }
            }catch (Exception ex)
            {

            }
        }

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            videoCaptureDevice.Stop();

        }
    }
}
