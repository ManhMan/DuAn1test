using _1.DAL.Entities;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmThongKe : Form
    {
        private IQLOderServices _order;
        private IQLOderDetailServices _orderdetail;
        private IQLCustomerServices _customer;
        private IQLProductServices _product;
        public List<Order> _lstOrder;
        public List<OrderDetail> _lstOrderDetail;
        public List<Customer> _lstCustomer;



        public FrmThongKe()
        {
            InitializeComponent();
            _order = new QLOderServices();
            _orderdetail = new QLOderDetailServices();
            _customer = new QLCustomerServices();
            _product = new QLProductServices();
            _lstOrder = new List<Order>();
            _lstOrderDetail = new List<OrderDetail>();
            _lstCustomer = new List<Customer>();
            loadData();
            loadDate();

        }
        public void loadData()
        {
            lb_doanhthu.Text = _order.GetOderFromDB().Sum(x => x.TotalPrice).ToString();
            lb_tonghd.Text = _order.GetOderFromDB().Count().ToString();
            lb_chuathanhtoan.Text = _order.GetOderFromDB().Where(x => x.Status == false).Count().ToString();
            lb_khachhang.Text = _customer.GetCustomerFromDB().Count().ToString();
        }

        public void loadDate()
        {
            for (int i = 1; i<13; i++)
            {
                cbb_thang.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            dtgv_show.Rows.Clear();
            var order = _order.GetOderFromDB().Where(x => x.dateCreate.ToString("dd-MM-yyyy") == dtp_ngay.Value.ToString("dd-MM-yyyy"));
            var x = (from a in order
                     join b in _customer.GetCustomerFromDB() on a.CustomerID equals b.ID
                     join c in _orderdetail.GetOderDetailFromDB() on a.Id equals c.OderID
                     join d in _product.GetProductFromDB() on c.ProducID equals d.Id
                     select new { a, b,c ,d});

            foreach(var i in x)
            {
                dtgv_show.Rows.Add(i.a.Id,i.d.Name, i.c.Quantity,i.c.Price,i.c.Quantity*i.c.Price,i.b.Phone);
            }
        }
    }
}
