namespace _3._Presentation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lb_taotk = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_quenmk = new System.Windows.Forms.Label();
            this.tbt_matk = new System.Windows.Forms.TextBox();
            this.tbt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_taotk
            // 
            this.lb_taotk.AutoSize = true;
            this.lb_taotk.ForeColor = System.Drawing.Color.Red;
            this.lb_taotk.Location = new System.Drawing.Point(47, 300);
            this.lb_taotk.Name = "lb_taotk";
            this.lb_taotk.Size = new System.Drawing.Size(78, 15);
            this.lb_taotk.TabIndex = 15;
            this.lb_taotk.Text = "Tạo tài khoản";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(47, 361);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(324, 45);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // lb_quenmk
            // 
            this.lb_quenmk.AutoSize = true;
            this.lb_quenmk.ForeColor = System.Drawing.Color.Red;
            this.lb_quenmk.Location = new System.Drawing.Point(277, 300);
            this.lb_quenmk.Name = "lb_quenmk";
            this.lb_quenmk.Size = new System.Drawing.Size(94, 15);
            this.lb_quenmk.TabIndex = 12;
            this.lb_quenmk.Text = "Quên mật khẩu?";
            // 
            // tbt_matk
            // 
            this.tbt_matk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_matk.Location = new System.Drawing.Point(47, 256);
            this.tbt_matk.Multiline = true;
            this.tbt_matk.Name = "tbt_matk";
            this.tbt_matk.PasswordChar = '*';
            this.tbt_matk.PlaceholderText = "Nhập mật khẩu";
            this.tbt_matk.Size = new System.Drawing.Size(324, 23);
            this.tbt_matk.TabIndex = 11;
            this.tbt_matk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbt_matk_MouseClick);
            // 
            // tbt_tk
            // 
            this.tbt_tk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_tk.Location = new System.Drawing.Point(47, 211);
            this.tbt_tk.Multiline = true;
            this.tbt_tk.Name = "tbt_tk";
            this.tbt_tk.PlaceholderText = "Nhập tài khoản";
            this.tbt_tk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbt_tk.Size = new System.Drawing.Size(324, 23);
            this.tbt_tk.TabIndex = 10;
            this.tbt_tk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbt_tk_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Russell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Khaki;
            this.ptb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_logo.BackgroundImage")));
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Location = new System.Drawing.Point(-1, 2);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(423, 124);
            this.ptb_logo.TabIndex = 8;
            this.ptb_logo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(424, 443);
            this.Controls.Add(this.lb_taotk);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_quenmk);
            this.Controls.Add(this.tbt_matk);
            this.Controls.Add(this.tbt_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_logo);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_taotk;
        private Button btn_login;
        private Label lb_quenmk;
        private TextBox tbt_matk;
        private TextBox tbt_tk;
        private Label label1;
        private PictureBox ptb_logo;
    }
}