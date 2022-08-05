using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3._Presentation
{
    public partial class FrmMain : Form
    {
        IQLEmployeeServices _iQLEmployee;

        public static bool session = false;
        
        public FrmMain()
        {
            InitializeComponent();
            _iQLEmployee = new QLEmployeeServices();
            this.CenterToScreen();
            //GoFullscreen(AutoSize);
            panel_ttnv.Visible = false;

        }
        public void chekCLose()
        {
            if (session == true)
            {
                this.Close();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var layEmail = Properties.Settings.Default.TKdaLogin;
            var nhanvien = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == layEmail);
            string linkanh = nhanvien.LinkAnh.Replace(@"\", @"/");
            pic_avtNV.Image = Image.FromFile(linkanh);
            pic_avtNV.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_tenNV.Text = "NV : " + nhanvien.FullName;
        }
        private Form activeForm;
        public void ChangeForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pn_main.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_nv_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            ChangeForm(frmNhanVien);
        }

        private void btn_banhang_Click_1(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang = new FrmBanHang();
            ChangeForm(frmBanHang);
        }

        private void btn_hoadon_Click_1(object sender, EventArgs e)
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            ChangeForm(frmHoaDon);
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            ChangeForm(frmSanPham);
        }

        private void btn_thongke_Click_1(object sender, EventArgs e)
        {
            FrmThongKe frmThongKe = new FrmThongKe();
            ChangeForm(frmThongKe);
        }
        int x = 260; int y = 20; int a = 1;
        private void timerChayChu_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                labelChaychu.Location = new Point(x, y);
                if (x >= 660)
                {
                    a = -2;
                }
                if (x <= 260)
                {
                    a = 2;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pcb_avtNV_Click(object sender, EventArgs e)
        {
            //FormThongTinNhanVien ttnv = new FormThongTinNhanVien();
            //ChangeForm(ttnv);
            panel_ttnv.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin logibn = new FrmLogin();
            logibn.ShowDialog();
            this.Close();
        }
    }
}