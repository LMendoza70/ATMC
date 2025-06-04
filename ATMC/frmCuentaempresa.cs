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
    public partial class frmCuentaempresa : Form
    {
        private CuentaEmpresa empresa;
        public frmCuentaempresa()
        {
            empresa = new CuentaEmpresa();
            InitializeComponent();
        }

        private void frmCuentaempresa_Load(object sender, EventArgs e)
        {
            //cargamos los datos de la cuenta a los controles que van a construir 
        }
    }
}
