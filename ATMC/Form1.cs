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

        //definimos atributos
        private CuentaFree cuenta;
        public Form1()
        {
            cuenta = new CuentaFree();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cuenta.Nombre;
            txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ "+cuenta.Saldo;
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta.Deposito(float.Parse(txtCantidad.Text));
                txtSaldo.Text = "$ " + cuenta.Saldo;
                txtCantidad.Text = "";
            }
            catch
            {
                MessageBox.Show("Datos capturados no validos","Cajero ATM");
                txtCantidad.Text = "";
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta.Retiro(float.Parse(txtCantidad.Text));
                txtSaldo.Text = "$ " + cuenta.Saldo;
                txtCantidad.Text = "";
            }
            catch
            {
                MessageBox.Show("Datos capturados no validos", "Cajero ATM");
                txtCantidad.Text = "";
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Estado(),"Cajero ATM");
        }
    }
}
