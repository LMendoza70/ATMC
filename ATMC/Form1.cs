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
        //creamos el objeto de la clase cuenta como atributo de la clase
        private CuentaFree cuenta;
        public Form1()
        {
            //inizializamos el objeto en el contructor
            cuenta=new CuentaFree();
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
