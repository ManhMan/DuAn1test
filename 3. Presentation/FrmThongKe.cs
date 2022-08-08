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
        public List<Order> _lstOrder;
        public List<OrderDetail> _lstOrderDetail;
        public List<Customer> _lstCustomer;



        public FrmThongKe()
        {
            InitializeComponent();
            _order = new QLOderServices();
            _orderdetail = new QLOderDetailServices();
            _customer = new QLCustomerServices();
            _lstOrder = new List<Order>();
            _lstOrderDetail = new List<OrderDetail>();
            _lstCustomer = new List<Customer>();
            loadData();
        }
        public void loadData()
        {
            lb_doanhthu.Text = _order.GetOderFromDB().Sum(x => x.TotalPrice).ToString();
            lb_tonghd.Text = _order.GetOderFromDB().Count().ToString();
            lb_chuathanhtoan.Text = _order.GetOderFromDB().Where(x => x.Status == false).Count().ToString();
            lb_khachhang.Text = _customer.GetCustomerFromDB().Count().ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
