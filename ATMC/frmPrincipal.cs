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
    public partial class frmPrincipal : Form
    {
        //creo una instancia del formulario a controlar
        private Form1 form1;
        private frmCuentaempresa empresa;
        private frmBase formbase;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmFrm1_Click(object sender, EventArgs e)
        {
            if(form1==null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                form1.BringToFront();
            }
            
        }

        private void tsmFrmEmpresa_Click(object sender, EventArgs e)
        {
            if(empresa==null || empresa.IsDisposed)
            {
                empresa = new frmCuentaempresa();
                empresa.MdiParent = this;
                empresa.Show();
            }
            else
            {
                empresa.BringToFront();
            }
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formbase==null || formbase.IsDisposed)
            {
                formbase = new frmBase();
                formbase.MdiParent = this;
                formbase.Show();
            }
            else
            {
                formbase.BringToFront();
            }
        }
    }
}
