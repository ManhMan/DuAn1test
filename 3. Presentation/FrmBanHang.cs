using _1.DAL.Entities;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._Presentation
{
    public partial class FrmBanHang : Form
    {
        private IQLProductServices _product;
        private IQLOderDetailServices _orderDetail;
        private IQLOderServices _order;
        private IQLEmployeeServices _employee;
        private IQLCustomerServices _customer;
        public List<OrderDetailVM> _lstOrderDetail;
        public int pID;
        public FrmBanHang()
        {
            InitializeComponent();
            _product = new QLProductServices();
            _orderDetail = new QLOderDetailServices();
            _order = new QLOderServices();
            _employee = new QLEmployeeServices();
            _customer = new QLCustomerServices();
            _lstOrderDetail = new List<OrderDetailVM>();
            loadSanPham();
        }
        public void loadSanPham()
        {
            dtg_danhsachSP.Rows.Clear();
            foreach (var item in _product.ShowProduct())
            {
                dtg_danhsachSP.Rows.Add(item.Id, item.Name, item.ProducerName, item.Price, item.Stock);
            }
        }

        public void loadGioHang()
        {
            dtg_giohang.Rows.Clear();
            foreach (var item in _lstOrderDetail)
            {
                dtg_giohang.Rows.Add(item.ProductID, item.ProductName, item.Price, item.Quantity);
            }
        }

        private void dtg_danhsachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow r = dtg_danhsachSP.Rows[e.RowIndex];
            pID = Convert.ToInt32(r.Cells[0].Value.ToString());
            var p = _product.GetProductFromDB().FirstOrDefault(x => x.ProducerID == pID);
            var data = _lstOrderDetail.FirstOrDefault(x => x.ProductID == p.Id);
            if (data == null)
            {
                OrderDetailVM orderDetailVM = new OrderDetailVM()
                {
                    ProductID = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    Quantity = 1
                };
                _lstOrderDetail.Add(orderDetailVM);
            }
            else
            {
                if (data.Quantity == p.Stock)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.Quantity++;
                }
            }
            loadGioHang();

        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
            pID = Convert.ToInt32(r.Cells[0].Value.ToString());

        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            var item = _lstOrderDetail.FirstOrDefault(x => x.ProductID == pID);
            _lstOrderDetail.Remove(item);
            loadGioHang();
        }

        private void btn_xoaGioHang_Click(object sender, EventArgs e)
        {
            _lstOrderDetail = new List<OrderDetailVM>();
            loadGioHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_lstOrderDetail.Any())
            {
                decimal total = 0;
                foreach (var item in _lstOrderDetail)
                {
                    total += item.Price * item.Quantity;
                }
                //int eID = _employee.GetEmployeeFromDB().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).ID;
                //int cID = _customer.GetCustomerFromDB().FirstOrDefault(x => x.Phone == "").ID;
                int eID = 1;
                int cID = 1;
                Order o = new Order()
                {
                    dateCreate = DateTime.Now,
                    EmployeeID = eID,
                    CustomerID = cID,
                    TotalPrice = total,
                    Status = false,
                    Note = ""
                };
                _order.AddOder(o);
                foreach (var item in _lstOrderDetail)
                {
                    OrderDetail od = new OrderDetail()
                    {
                        OderID = o.Id,
                        ProducID = item.ProductID,
                        Price = item.Price,
                        Quantity = item.Quantity
                    };
                    _orderDetail.AddOderDetail(od);
                }

                tbt_mahd.Text = o.Id.ToString();
                lb_tongtien.Text = o.TotalPrice.ToString();
                MessageBox.Show($"Tạo hóa đơn thành công. ID: {o.Id}");
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        private void tbt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Order o = _order.GetOderFromDB().FirstOrDefault(x => x.Id == Convert.ToInt32(tbt_mahd.Text) && x.Status == false);
            if (o == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                lb_tongtien.Text = "0";
            }
            else
            {
                if (Convert.ToDecimal(lb_tienthua.Text) < 0 || tbt_tienkhachdua.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        o.Status = true;
                        _order.UpdateOder(o);
                        MessageBox.Show("Thanh toán thành công");
                    }
                }
            }
        }

        private void tbt_mahd_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void tbt_tienkhachdua_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void tbt_mahd_TextChanged(object sender, EventArgs e)
        {
            Order o = _order.GetOderFromDB().FirstOrDefault(x => x.Id == Convert.ToInt32(tbt_mahd.Text) && x.Status == false);
            if (o != null)
            {
                lb_tongtien.Text = o.TotalPrice.ToString();
            }
            else
            {
                lb_tongtien.Text = "0";
            }
        }

        private void tbt_giamgia_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }
        public void loadTienThua()
        {
            if (tbt_giamgia.Text == "")
            {
                if (decimal.TryParse(tbt_tienkhachdua.Text, out decimal x))
                {
                    lb_tienthua.Text = (Convert.ToDecimal(tbt_tienkhachdua.Text) - Convert.ToDecimal(lb_tongtien.Text)).ToString();
                }
            }
            else
            {
                if (decimal.TryParse(tbt_tienkhachdua.Text, out decimal x) && decimal.TryParse(tbt_giamgia.Text, out decimal y))
                {
                    lb_tienthua.Text = (Convert.ToDecimal(tbt_tienkhachdua.Text) - Convert.ToDecimal(lb_tongtien.Text) + Convert.ToDecimal(tbt_giamgia.Text)).ToString();
                }
            }
        }
    }
}
