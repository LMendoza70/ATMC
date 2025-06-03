using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetiro_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnRetiro.BackColor = System.Drawing.Color.Red;
        }

        private void btnRetiro_MouseLeave(object sender, EventArgs e)
        {
            this.btnRetiro.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
