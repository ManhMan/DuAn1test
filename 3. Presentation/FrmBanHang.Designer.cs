namespace _3._Presentation
{
    partial class FrmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbt_timkSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_danhsachSP = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbt_mahd = new System.Windows.Forms.TextBox();
            this.tbt_tienkhachdua = new System.Windows.Forms.TextBox();
            this.tbt_giamgia = new System.Windows.Forms.TextBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_tienthua = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_point = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoaGioHang = new System.Windows.Forms.Button();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.lb_totalprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_giohang = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 860);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbt_timkSP);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtg_danhsachSP);
            this.groupBox3.Location = new System.Drawing.Point(19, 337);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(809, 432);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbt_timkSP
            // 
            this.tbt_timkSP.Location = new System.Drawing.Point(18, 51);
            this.tbt_timkSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_timkSP.Multiline = true;
            this.tbt_timkSP.Name = "tbt_timkSP";
            this.tbt_timkSP.Size = new System.Drawing.Size(194, 43);
            this.tbt_timkSP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm sản phẩm";
            // 
            // dtg_danhsachSP
            // 
            this.dtg_danhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dtg_danhsachSP.Location = new System.Drawing.Point(7, 112);
            this.dtg_danhsachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_danhsachSP.Name = "dtg_danhsachSP";
            this.dtg_danhsachSP.RowHeadersWidth = 51;
            this.dtg_danhsachSP.RowTemplate.Height = 25;
            this.dtg_danhsachSP.Size = new System.Drawing.Size(688, 283);
            this.dtg_danhsachSP.TabIndex = 1;
            this.dtg_danhsachSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachSP_CellClick);
            this.dtg_danhsachSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachSP_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhà sản xuất";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng tồn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbt_mahd);
            this.groupBox2.Controls.Add(this.tbt_tienkhachdua);
            this.groupBox2.Controls.Add(this.tbt_giamgia);
            this.groupBox2.Controls.Add(this.btn_thanhtoan);
            this.groupBox2.Controls.Add(this.rtb_ghichu);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lb_tienthua);
            this.groupBox2.Controls.Add(this.lb_tongtien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(834, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(470, 432);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbt_mahd
            // 
            this.tbt_mahd.Location = new System.Drawing.Point(194, 32);
            this.tbt_mahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_mahd.Name = "tbt_mahd";
            this.tbt_mahd.Size = new System.Drawing.Size(114, 27);
            this.tbt_mahd.TabIndex = 42;
            this.tbt_mahd.TextChanged += new System.EventHandler(this.tbt_mahd_TextChanged_1);
            // 
            // tbt_tienkhachdua
            // 
            this.tbt_tienkhachdua.Location = new System.Drawing.Point(195, 137);
            this.tbt_tienkhachdua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_tienkhachdua.Name = "tbt_tienkhachdua";
            this.tbt_tienkhachdua.Size = new System.Drawing.Size(114, 27);
            this.tbt_tienkhachdua.TabIndex = 41;
            this.tbt_tienkhachdua.TextChanged += new System.EventHandler(this.tbt_tienkhachdua_TextChanged_1);
            // 
            // tbt_giamgia
            // 
            this.tbt_giamgia.Location = new System.Drawing.Point(194, 85);
            this.tbt_giamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_giamgia.Name = "tbt_giamgia";
            this.tbt_giamgia.Size = new System.Drawing.Size(114, 27);
            this.tbt_giamgia.TabIndex = 40;
            this.tbt_giamgia.TextChanged += new System.EventHandler(this.tbt_giamgia_TextChanged_1);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_thanhtoan.Image")));
            this.btn_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhtoan.Location = new System.Drawing.Point(122, 344);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(242, 63);
            this.btn_thanhtoan.TabIndex = 39;
            this.btn_thanhtoan.Text = "THANH TOÁN";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click_1);
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(195, 291);
            this.rtb_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(187, 27);
            this.rtb_ghichu.TabIndex = 38;
            this.rtb_ghichu.Text = "";
            this.rtb_ghichu.TextChanged += new System.EventHandler(this.rtb_ghichu_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(69, 298);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 20);
            this.label21.TabIndex = 37;
            this.label21.Text = "Ghi chú";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(342, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "VNĐ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(342, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "VNĐ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(342, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "VNĐ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lb_tienthua
            // 
            this.lb_tienthua.AutoSize = true;
            this.lb_tienthua.Location = new System.Drawing.Point(194, 193);
            this.lb_tienthua.Name = "lb_tienthua";
            this.lb_tienthua.Size = new System.Drawing.Size(17, 20);
            this.lb_tienthua.TabIndex = 33;
            this.lb_tienthua.Text = "0";
            this.lb_tienthua.Click += new System.EventHandler(this.lb_tienthua_Click);
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(194, 243);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(17, 20);
            this.lb_tongtien.TabIndex = 32;
            this.lb_tongtien.Text = "0";
            this.lb_tongtien.Click += new System.EventHandler(this.lb_tongtien_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tiền thừa";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tiền khách đưa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giảm giá";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tổng tiền";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã hóa đơn ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_point);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lb_tenkh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_xoaGioHang);
            this.groupBox1.Controls.Add(this.btn_XoaSP);
            this.groupBox1.Controls.Add(this.lb_totalprice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtg_giohang);
            this.groupBox1.Location = new System.Drawing.Point(19, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1285, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_point
            // 
            this.lb_point.AutoSize = true;
            this.lb_point.Location = new System.Drawing.Point(869, 141);
            this.lb_point.Name = "lb_point";
            this.lb_point.Size = new System.Drawing.Size(18, 20);
            this.lb_point.TabIndex = 23;
            this.lb_point.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(744, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Điểm tích lũy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox1.Location = new System.Drawing.Point(1038, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 203);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Location = new System.Drawing.Point(869, 99);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(18, 20);
            this.lb_tenkh.TabIndex = 20;
            this.lb_tenkh.Text = "...";
            this.lb_tenkh.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(744, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên khách hàng";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(744, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sđt khách hàng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(869, 55);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(125, 27);
            this.tb_sdt.TabIndex = 17;
            this.tb_sdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(592, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tạo hóa đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_xoaGioHang
            // 
            this.btn_xoaGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaGioHang.Image")));
            this.btn_xoaGioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaGioHang.Location = new System.Drawing.Point(592, 99);
            this.btn_xoaGioHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoaGioHang.Name = "btn_xoaGioHang";
            this.btn_xoaGioHang.Size = new System.Drawing.Size(126, 44);
            this.btn_xoaGioHang.TabIndex = 15;
            this.btn_xoaGioHang.Text = "Xóa giỏ hàng";
            this.btn_xoaGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaGioHang.UseVisualStyleBackColor = true;
            this.btn_xoaGioHang.Click += new System.EventHandler(this.btn_xoaGioHang_Click_1);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaSP.Image")));
            this.btn_XoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaSP.Location = new System.Drawing.Point(592, 47);
            this.btn_XoaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(126, 44);
            this.btn_XoaSP.TabIndex = 14;
            this.btn_XoaSP.Text = "Xóa sản phẩm";
            this.btn_XoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click_1);
            // 
            // lb_totalprice
            // 
            this.lb_totalprice.AutoSize = true;
            this.lb_totalprice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_totalprice.Location = new System.Drawing.Point(733, 260);
            this.lb_totalprice.Name = "lb_totalprice";
            this.lb_totalprice.Size = new System.Drawing.Size(27, 31);
            this.lb_totalprice.TabIndex = 12;
            this.lb_totalprice.Text = "0";
            this.lb_totalprice.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(592, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng tiền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtg_giohang
            // 
            this.dtg_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_giohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column10,
            this.Column9});
            this.dtg_giohang.Location = new System.Drawing.Point(6, 47);
            this.dtg_giohang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_giohang.Name = "dtg_giohang";
            this.dtg_giohang.RowHeadersWidth = 51;
            this.dtg_giohang.RowTemplate.Height = 25;
            this.dtg_giohang.Size = new System.Drawing.Size(562, 253);
            this.dtg_giohang.TabIndex = 0;
            this.dtg_giohang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_giohang_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên sản phẩm";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Đơn giá";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 828);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private TextBox tbt_timkSP;
        private Label label1;
        private DataGridView dtg_danhsachSP;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dtg_giohang;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private TextBox tbt_mahd;
        private TextBox tbt_tienkhachdua;
        private TextBox tbt_giamgia;
        private Button btn_thanhtoan;
        private RichTextBox rtb_ghichu;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label16;
        private Label lb_tienthua;
        private Label lb_tongtien;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button btn_xoaGioHang;
        private Button btn_XoaSP;
        private Label lb_totalprice;
        private Label lb_tenkh;
        private Label label10;
        private Label label9;
        private TextBox tb_sdt;
        private PictureBox pictureBox1;
        private Label label11;
        private Label lb_point;
    }
}