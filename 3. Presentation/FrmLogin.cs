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
        }

        private void tbt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_tk.Text = "";
        }

        private void tbt_matk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_matk.Text = "";
        }
    }
}
