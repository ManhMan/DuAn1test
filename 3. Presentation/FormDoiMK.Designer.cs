﻿namespace _3._Presentation
{
    partial class FormDoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mkcu = new System.Windows.Forms.TextBox();
            this.textBox_mkmoi = new System.Windows.Forms.TextBox();
            this.textBox_nhaplaimk = new System.Windows.Forms.TextBox();
            this.button_doimk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox_mkcu
            // 
            this.textBox_mkcu.Location = new System.Drawing.Point(173, 29);
            this.textBox_mkcu.Name = "textBox_mkcu";
            this.textBox_mkcu.Size = new System.Drawing.Size(189, 23);
            this.textBox_mkcu.TabIndex = 3;
            // 
            // textBox_mkmoi
            // 
            this.textBox_mkmoi.Location = new System.Drawing.Point(173, 71);
            this.textBox_mkmoi.Name = "textBox_mkmoi";
            this.textBox_mkmoi.Size = new System.Drawing.Size(189, 23);
            this.textBox_mkmoi.TabIndex = 4;
            // 
            // textBox_nhaplaimk
            // 
            this.textBox_nhaplaimk.Location = new System.Drawing.Point(173, 118);
            this.textBox_nhaplaimk.Name = "textBox_nhaplaimk";
            this.textBox_nhaplaimk.Size = new System.Drawing.Size(189, 23);
            this.textBox_nhaplaimk.TabIndex = 5;
            // 
            // button_doimk
            // 
            this.button_doimk.Location = new System.Drawing.Point(103, 164);
            this.button_doimk.Name = "button_doimk";
            this.button_doimk.Size = new System.Drawing.Size(188, 31);
            this.button_doimk.TabIndex = 6;
            this.button_doimk.Text = "Đổi mật khẩu";
            this.button_doimk.UseVisualStyleBackColor = true;
            this.button_doimk.Click += new System.EventHandler(this.button_doimk_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 353);
            this.Controls.Add(this.button_doimk);
            this.Controls.Add(this.textBox_nhaplaimk);
            this.Controls.Add(this.textBox_mkmoi);
            this.Controls.Add(this.textBox_mkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_mkcu;
        private TextBox textBox_mkmoi;
        private TextBox textBox_nhaplaimk;
        private Button button_doimk;
    }
}