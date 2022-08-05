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
    public partial class FormThongTinNhanVien : Form
    {
        IQLEmployeeServices _iQLEmployee;
        bool chekDMK;
        public FormThongTinNhanVien()
        {
            InitializeComponent();
            _iQLEmployee = new QLEmployeeServices();
            this.CenterToScreen();
        }

       

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            var nhanvien = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == Properties.Settings.Default.TKdaLogin);

            lb_maNV.Text = nhanvien.MaNV.ToString();
            labe_ten.Text = nhanvien.FullName;
            label_sdt.Text = nhanvien.Phone;
            label_email.Text = nhanvien.Email;
            label_gioitinh.Text = nhanvien.Sex == true ? "Nam" : "Nữ";
            string formattedDate = nhanvien.Dob.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 
            label_ngaysinh.Text = Convert.ToString(formattedDate);
            label_diachi.Text = nhanvien.Address;
        }

        private void button_doimk_Click(object sender, EventArgs e)
        {
            var mk = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Password == textBox_mkcu.Text);
            if (mk == null)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");

            }
            else if (textBox_mkmoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự");

            }
            else if (textBox_nhaplaimk.Text != textBox_mkmoi.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }


            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var mkmoi = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault();
                    mkmoi.Password = textBox_mkmoi.Text;
                    _iQLEmployee.UpdateEmployee(mkmoi);
                    
                    FrmMain.session = true;
                    MessageBox.Show("Đổi mật khẩu thành công");
                    


                }
                
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
