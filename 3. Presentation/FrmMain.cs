namespace _3._Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
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
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang = new FrmBanHang();
            ChangeForm(frmBanHang);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            ChangeForm(frmSanPham);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            ChangeForm(frmHoaDon);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            ChangeForm(frmNhanVien);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            FrmThongKe frmThongKe = new FrmThongKe();
            ChangeForm(frmThongKe);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}