﻿namespace _3._Presentation
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timk = new System.Windows.Forms.Button();
            this.tbt_timkKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_KH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(781, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_nu);
            this.panel2.Controls.Add(this.rb_nam);
            this.panel2.Location = new System.Drawing.Point(579, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 40);
            this.panel2.TabIndex = 26;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(87, 11);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(41, 19);
            this.rb_nu.TabIndex = 19;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(3, 11);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(51, 19);
            this.rb_nam.TabIndex = 18;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 649);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timk);
            this.groupBox2.Controls.Add(this.tbt_timkKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(9, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // btn_timk
            // 
            this.btn_timk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_timk.Image = ((System.Drawing.Image)(resources.GetObject("btn_timk.Image")));
            this.btn_timk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timk.Location = new System.Drawing.Point(330, 35);
            this.btn_timk.Name = "btn_timk";
            this.btn_timk.Size = new System.Drawing.Size(85, 23);
            this.btn_timk.TabIndex = 11;
            this.btn_timk.Text = "Tìm kiếm";
            this.btn_timk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timk.UseVisualStyleBackColor = false;
            // 
            // tbt_timkKH
            // 
            this.tbt_timkKH.Location = new System.Drawing.Point(152, 37);
            this.tbt_timkKH.Name = "tbt_timkKH";
            this.tbt_timkKH.Size = new System.Drawing.Size(174, 23);
            this.tbt_timkKH.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm Kiếm Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbt_diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbt_sdt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbt_KH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Khách Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Giới tính";
            // 
            // tbt_diachi
            // 
            this.tbt_diachi.Location = new System.Drawing.Point(579, 114);
            this.tbt_diachi.Name = "tbt_diachi";
            this.tbt_diachi.Size = new System.Drawing.Size(131, 23);
            this.tbt_diachi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ";
            // 
            // tbt_sdt
            // 
            this.tbt_sdt.Location = new System.Drawing.Point(195, 114);
            this.tbt_sdt.Name = "tbt_sdt";
            this.tbt_sdt.Size = new System.Drawing.Size(131, 23);
            this.tbt_sdt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số điện thoại";
            // 
            // tbt_KH
            // 
            this.tbt_KH.Location = new System.Drawing.Point(195, 47);
            this.tbt_KH.Name = "tbt_KH";
            this.tbt_KH.Size = new System.Drawing.Size(131, 23);
            this.tbt_KH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(855, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 258);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(37, 61);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 33);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Cập Nhập";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(37, 22);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 33);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private RadioButton rb_nu;
        private RadioButton rb_nam;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox tbt_diachi;
        private Label label3;
        private TextBox tbt_sdt;
        private Label label2;
        private GroupBox groupBox3;
        private Button btn_sua;
        private Button btn_them;
        private TextBox tbt_KH;
        private Label label1;
        private Button btn_timk;
        private TextBox tbt_timkKH;
        private Label label5;
    }
}