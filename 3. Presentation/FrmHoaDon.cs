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
    public partial class FrmHoaDon : Form
    {
        private IQLOderServices _order;
        private IQLOderDetailServices _orderDetail;
        public FrmHoaDon()
        {
            InitializeComponent();
            _order = new QLOderServices();
            _orderDetail = new QLOderDetailServices();
            loadOrder();
        }
        public void loadOrder()
        {
            dtg_hoadon.Rows.Clear();
            dtg_hoadonchitiet.Rows.Clear();
            foreach (var item in _order.ShowOrder())
            {
                dtg_hoadon.Rows.Add(item.ID, item.DateCreated, item.EmployeeEmail, item.CustomerPhoneNumber, item.TotalPrice, item.Status ? "Đã thanh toán" : "Chờ thanh toán", item.Note);
            }
        }
        public void loadOrderDetail(int orderID)
        {
            dtg_hoadonchitiet.Rows.Clear();
            foreach (var item in _orderDetail.ShowOrderDetail(orderID))
            {
                dtg_hoadonchitiet.Rows.Add(item.ProductID, item.ProductName, item.Quantity, item.Price);
            }
        }

        private void btn_timk_Click(object sender, EventArgs e)
        {
            dtg_hoadon.Rows.Clear();
            dtg_hoadonchitiet.Rows.Clear();
            int value;
            if (tbt_timk.Text != "")
            {
                if (int.TryParse(tbt_timk.Text, out value))
                {
                    var items = _order.ShowOrder().Where(x => x.ID.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var item in items)
                        {
                            dtg_hoadon.Rows.Add(item.ID, item.DateCreated, item.EmployeeEmail, item.CustomerPhoneNumber, item.TotalPrice, item.Status ? "Đã thanh toán" : "Chờ thanh toán", item.Note);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn tương ứng");
                        loadOrder();
                    }
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn phải là số");
                    loadOrder();
                }
            }
        }

        private void dtg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtg_hoadon.Rows[e.RowIndex];
            loadOrderDetail(Convert.ToInt32(r.Cells[0].Value));

        }
    }
}
