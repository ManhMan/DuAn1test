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
    public partial class FrmSanPham : Form
    {
        public IQLProductServices _IQLProductServices;
        public IQLProducerServices _IQLProducerServices;

        public FrmSanPham()
        {
            InitializeComponent();
            _IQLProductServices = new QLProductServices();
            _IQLProducerServices = new QLProducerServises();
            LoadData();
        }
        public void LoadData()
        {


            dtgv_frmSP.Rows.Clear();
            //dtgv_frmSP.DataSource = _IQLProductServices.ShowProduct();
            foreach (var item in _IQLProductServices.GetProductFromDB())
            {
                dtgv_frmSP.Rows.Add(item.Id,item.Name,item.Price,item.OriginalPrice,item.DateCreated,item.OriginalPrice,item.Note);
            }

        }

        private void tbt_ghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
