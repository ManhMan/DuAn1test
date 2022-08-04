namespace _3._Presentation
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.lb_tenNV = new System.Windows.Forms.Label();
            this.btn_nv = new System.Windows.Forms.Button();
            this.pcb_avtNV = new System.Windows.Forms.PictureBox();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.labelChaychu = new System.Windows.Forms.Label();
            this.timerChayChu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_avtNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_hoadon);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_sp);
            this.panel1.Controls.Add(this.lb_tenNV);
            this.panel1.Controls.Add(this.btn_nv);
            this.panel1.Controls.Add(this.pcb_avtNV);
            this.panel1.Controls.Add(this.btn_banhang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 648);
            this.panel1.TabIndex = 0;
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hoadon.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hoadon.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_hoadon.Image")));
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(12, 295);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(224, 57);
            this.btn_hoadon.TabIndex = 8;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click_1);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_thongke.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongke.Image")));
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(12, 517);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(224, 57);
            this.btn_thongke.TabIndex = 11;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click_1);
            // 
            // btn_sp
            // 
            this.btn_sp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sp.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sp.ForeColor = System.Drawing.Color.White;
            this.btn_sp.Image = ((System.Drawing.Image)(resources.GetObject("btn_sp.Image")));
            this.btn_sp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sp.Location = new System.Drawing.Point(12, 444);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(224, 57);
            this.btn_sp.TabIndex = 10;
            this.btn_sp.Text = "Sản Phẩm";
            this.btn_sp.UseVisualStyleBackColor = false;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // lb_tenNV
            // 
            this.lb_tenNV.AutoSize = true;
            this.lb_tenNV.Location = new System.Drawing.Point(103, 180);
            this.lb_tenNV.Name = "lb_tenNV";
            this.lb_tenNV.Size = new System.Drawing.Size(44, 15);
            this.lb_tenNV.TabIndex = 1;
            this.lb_tenNV.Text = "Tên NV";
            this.lb_tenNV.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_nv
            // 
            this.btn_nv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nv.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nv.ForeColor = System.Drawing.Color.White;
            this.btn_nv.Image = ((System.Drawing.Image)(resources.GetObject("btn_nv.Image")));
            this.btn_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nv.Location = new System.Drawing.Point(12, 368);
            this.btn_nv.Name = "btn_nv";
            this.btn_nv.Size = new System.Drawing.Size(224, 57);
            this.btn_nv.TabIndex = 9;
            this.btn_nv.Text = "Nhân Viên";
            this.btn_nv.UseVisualStyleBackColor = false;
            this.btn_nv.Click += new System.EventHandler(this.btn_nv_Click);
            // 
            // pcb_avtNV
            // 
            this.pcb_avtNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcb_avtNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_avtNV.BackgroundImage")));
            this.pcb_avtNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_avtNV.Location = new System.Drawing.Point(50, 33);
            this.pcb_avtNV.Name = "pcb_avtNV";
            this.pcb_avtNV.Size = new System.Drawing.Size(156, 144);
            this.pcb_avtNV.TabIndex = 0;
            this.pcb_avtNV.TabStop = false;
            // 
            // btn_banhang
            // 
            this.btn_banhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_banhang.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_banhang.ForeColor = System.Drawing.Color.White;
            this.btn_banhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_banhang.Image")));
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(12, 220);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(224, 57);
            this.btn_banhang.TabIndex = 7;
            this.btn_banhang.Text = "Bán Hàng";
            this.btn_banhang.UseVisualStyleBackColor = false;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click_1);
            // 
            // pn_main
            // 
            this.pn_main.Location = new System.Drawing.Point(261, 76);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(972, 535);
            this.pn_main.TabIndex = 1;
            // 
            // labelChaychu
            // 
            this.labelChaychu.AutoSize = true;
            this.labelChaychu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelChaychu.Location = new System.Drawing.Point(455, 23);
            this.labelChaychu.Name = "labelChaychu";
            this.labelChaychu.Size = new System.Drawing.Size(467, 32);
            this.labelChaychu.TabIndex = 2;
            this.labelChaychu.Text = "Khách hàng là thượng đế, không được đánh";
            // 
            // timerChayChu
            // 
            this.timerChayChu.Enabled = true;
            this.timerChayChu.Interval = 20;
            this.timerChayChu.Tick += new System.EventHandler(this.timerChayChu_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1245, 648);
            this.Controls.Add(this.labelChaychu);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_avtNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel pn_main;
        private Label lb_tenNV;
        private PictureBox pcb_avtNV;
        private Button btn_hoadon;
        private Button btn_thongke;
        private Button btn_sp;
        private Button btn_nv;
        private Button btn_banhang;
        private Label labelChaychu;
        private System.Windows.Forms.Timer timerChayChu;
    }
}