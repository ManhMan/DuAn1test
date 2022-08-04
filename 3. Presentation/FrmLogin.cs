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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void tbt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_tk.Text = "";
        }

        private void tbt_matk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_matk.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();    
            frmMain.ShowDialog();
        }
    }
}
