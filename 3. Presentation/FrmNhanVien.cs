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
    public partial class FrmNhanVien : Form
    {
        IQLEmployeeServices _iQLEmployee;
        IQLRoleServices _iQLRole;
        string linkAnh = "";
        Employee employee;
        public FrmNhanVien()
        {
            InitializeComponent();
            _iQLEmployee = new QLEmployeeServices();
            _iQLRole = new QLRoleServices();
            foreach (var item in _iQLRole.GetProductFromDB())
            {
                cbb_chucvu.Items.Add(item.RoleName);
            }
            loadNhanVien();
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int idss = _iQLEmployee.GetEmployeeFromDB().Count() + 1;
            Employee employeee = new Employee()
            {
                
                MaNV = "NV" + idss,
                Email = tbt_Email.Text,
                Password = "123",
                FullName = tbt_tenNV.Text,
                Status = rad_hd.Checked,
                Sex = rb_nam.Checked,
                Dob = dtp_ngaysinh.Value,
                Address = tbt_diachi.Text,
                Phone = tbt_sdt.Text,
                IDRoles = cbb_chucvu.Text == "Quản lý" ? 1 : 2,
                LinkAnh = linkAnh
            };
            _iQLEmployee.AddEmployee(employeee);
            MessageBox.Show("Thêm Nhân Viên thành công");
            loadNhanVien();
        }

        public void loadNhanVien()
        {
            dgv_nhanvien.Rows.Clear();
            foreach (var item in _iQLEmployee.GetEmployeeFromDB())
            {
                dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex ==true ? "Nam" : "Nữ",
                    _iQLRole.GetProductFromDB().Where(p=>p.ID == item.IDRoles).Select(p=>p.RoleName).FirstOrDefault(),
                    item.Status == true ? "Hoạt Động" : "Không hoạt động",
                    item.Dob);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            employee.FullName=tbt_tenNV.Text;
            employee.Sex=rb_nam.Checked ;
            employee.Dob = dtp_ngaysinh.Value;
            employee.IDRoles=cbb_chucvu.Text=="Quản lý"?1:2;
            employee.Address= tbt_diachi.Text;
            employee.Phone = tbt_sdt.Text;

            employee.Status = rad_hd.Checked;
            employee.LinkAnh=linkAnh;
            if (employee.Email == tbt_Email.Text)
            {
                _iQLEmployee.UpdateEmployee(employee);
                MessageBox.Show("Sửa Nhân Viên thành công");
                loadNhanVien();
            }
            else
            {
                MessageBox.Show("Cút");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                linkAnh = op.FileName;
                pictureBox1.Image = Image.FromFile(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_nhanvien.Rows[e.RowIndex];
            employee = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.MaNV == r.Cells[0].Value.ToString());
            tbt_tenNV.Text = r.Cells[1].Value.ToString();
            tbt_sdt.Text = r.Cells[2].Value.ToString();
            rb_nam.Checked = r.Cells[4].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = r.Cells[4].Value.ToString() == "Nữ" ? true : false;
            dtp_ngaysinh.Value = Convert.ToDateTime(r.Cells[7].Value);
            tbt_Email.Text = employee.Email ;
            cbb_chucvu.Text = r.Cells[5].Value.ToString();
            tbt_diachi.Text = r.Cells[3].Value.ToString(); ;
            rad_hd.Checked = r.Cells[6].Value.ToString() == "Hoạt Động" ? true : false; ;
            rad_khd.Checked = r.Cells[6].Value.ToString() == "Không hoạt động" ? true : false; ;
            //var layLinkAnh = _iQLEmployee.GetEmployeeFromDB().Where(p => p.ID.ToString() == ().Select(p => p.li).FirstOrDefault();
            linkAnh = employee.LinkAnh;
            pictureBox1.Image = Image.FromFile(linkAnh);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
