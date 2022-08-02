namespace _3._Presentation
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_dsnv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_locGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbb_locChucVu = new System.Windows.Forms.ComboBox();
            this.btn_timk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbt_maNV = new System.Windows.Forms.TextBox();
            this.tbt_tk = new System.Windows.Forms.TextBox();
            this.tbt_mk = new System.Windows.Forms.TextBox();
            this.tbt_tenNV = new System.Windows.Forms.TextBox();
            this.tbt_diachi = new System.Windows.Forms.TextBox();
            this.tbt_sdt = new System.Windows.Forms.TextBox();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsnv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 523);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.cbb_chucvu);
            this.groupBox1.Controls.Add(this.cbb_trangthai);
            this.groupBox1.Controls.Add(this.tbt_sdt);
            this.groupBox1.Controls.Add(this.tbt_diachi);
            this.groupBox1.Controls.Add(this.tbt_tenNV);
            this.groupBox1.Controls.Add(this.tbt_mk);
            this.groupBox1.Controls.Add(this.tbt_tk);
            this.groupBox1.Controls.Add(this.tbt_maNV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timk);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_locChucVu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbb_locGioiTinh);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtg_dsnv);
            this.groupBox2.Location = new System.Drawing.Point(17, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dtg_dsnv
            // 
            this.dtg_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dsnv.Location = new System.Drawing.Point(9, 73);
            this.dtg_dsnv.Name = "dtg_dsnv";
            this.dtg_dsnv.RowTemplate.Height = 25;
            this.dtg_dsnv.Size = new System.Drawing.Size(760, 171);
            this.dtg_dsnv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lọc theo giới tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lọc theo chức vụ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbb_locGioiTinh
            // 
            this.cbb_locGioiTinh.FormattingEnabled = true;
            this.cbb_locGioiTinh.Location = new System.Drawing.Point(420, 44);
            this.cbb_locGioiTinh.Name = "cbb_locGioiTinh";
            this.cbb_locGioiTinh.Size = new System.Drawing.Size(121, 23);
            this.cbb_locGioiTinh.TabIndex = 5;
            // 
            // cbb_locChucVu
            // 
            this.cbb_locChucVu.FormattingEnabled = true;
            this.cbb_locChucVu.Location = new System.Drawing.Point(627, 44);
            this.cbb_locChucVu.Name = "cbb_locChucVu";
            this.cbb_locChucVu.Size = new System.Drawing.Size(121, 23);
            this.cbb_locChucVu.TabIndex = 6;
            // 
            // btn_timk
            // 
            this.btn_timk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_timk.Image = ((System.Drawing.Image)(resources.GetObject("btn_timk.Image")));
            this.btn_timk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timk.Location = new System.Drawing.Point(310, 44);
            this.btn_timk.Name = "btn_timk";
            this.btn_timk.Size = new System.Drawing.Size(85, 23);
            this.btn_timk.TabIndex = 7;
            this.btn_timk.Text = "Tìm kiếm";
            this.btn_timk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timk.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số điện thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Chức vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Trạng thái";
            // 
            // tbt_maNV
            // 
            this.tbt_maNV.Location = new System.Drawing.Point(154, 28);
            this.tbt_maNV.Name = "tbt_maNV";
            this.tbt_maNV.Size = new System.Drawing.Size(128, 23);
            this.tbt_maNV.TabIndex = 10;
            // 
            // tbt_tk
            // 
            this.tbt_tk.Location = new System.Drawing.Point(154, 69);
            this.tbt_tk.Name = "tbt_tk";
            this.tbt_tk.Size = new System.Drawing.Size(128, 23);
            this.tbt_tk.TabIndex = 11;
            // 
            // tbt_mk
            // 
            this.tbt_mk.Location = new System.Drawing.Point(154, 110);
            this.tbt_mk.Name = "tbt_mk";
            this.tbt_mk.Size = new System.Drawing.Size(128, 23);
            this.tbt_mk.TabIndex = 12;
            // 
            // tbt_tenNV
            // 
            this.tbt_tenNV.Location = new System.Drawing.Point(154, 148);
            this.tbt_tenNV.Name = "tbt_tenNV";
            this.tbt_tenNV.Size = new System.Drawing.Size(128, 23);
            this.tbt_tenNV.TabIndex = 13;
            // 
            // tbt_diachi
            // 
            this.tbt_diachi.Location = new System.Drawing.Point(393, 110);
            this.tbt_diachi.Name = "tbt_diachi";
            this.tbt_diachi.Size = new System.Drawing.Size(128, 23);
            this.tbt_diachi.TabIndex = 14;
            // 
            // tbt_sdt
            // 
            this.tbt_sdt.Location = new System.Drawing.Point(393, 148);
            this.tbt_sdt.Name = "tbt_sdt";
            this.tbt_sdt.Size = new System.Drawing.Size(128, 23);
            this.tbt_sdt.TabIndex = 15;
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Location = new System.Drawing.Point(154, 189);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(128, 23);
            this.cbb_trangthai.TabIndex = 16;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(393, 186);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(128, 23);
            this.cbb_chucvu.TabIndex = 17;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(393, 32);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(51, 19);
            this.rb_nam.TabIndex = 18;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(480, 32);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(41, 19);
            this.rb_nu.TabIndex = 19;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(393, 70);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaysinh.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(611, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 210);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(28, 22);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 33);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(28, 61);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 33);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsnv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cbb_locChucVu;
        private ComboBox cbb_locGioiTinh;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dtg_dsnv;
        private Button btn_timk;
        private Label label4;
        private Label label5;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Button btn_sua;
        private Button btn_them;
        private DateTimePicker dtp_ngaysinh;
        private RadioButton rb_nu;
        private RadioButton rb_nam;
        private ComboBox cbb_chucvu;
        private ComboBox cbb_trangthai;
        private TextBox tbt_sdt;
        private TextBox tbt_diachi;
        private TextBox tbt_tenNV;
        private TextBox tbt_mk;
        private TextBox tbt_tk;
        private TextBox tbt_maNV;
    }
}