using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ATMC
{
    public partial class frmCuentaempresa : Form
    {
        string lista;
        private CuentaEmpresa empresa;
        public frmCuentaempresa()
        {
            empresa = new CuentaEmpresa();
            InitializeComponent();
        }

        private void frmCuentaempresa_Load(object sender, EventArgs e)
        {
            //creamos un arraylist de objetos categoria
            ArrayList categorias = new ArrayList();

            categorias.Add(new clsCategorias(1, "Caballero"));
            categorias.Add(new clsCategorias(2, "Damas"));
            categorias.Add(new clsCategorias(3, "Calzado"));
            categorias.Add(new clsCategorias(4, "Acsesorios"));
            categorias.Add(new clsCategorias(5, "Kids"));
            categorias.Add(new clsCategorias(6, "Uno mas"));
            categorias.Add(new clsCategorias(20, "ejemplo"));

            //relacionamos el combo box con la lista de categorias
            cmbCategorias.DataSource = categorias;
            //utilizando la propiedad displaymember mostramos los elemntos
            cmbCategorias.DisplayMember = "nombre";
            //asignamos la propiedad valuemember al cmb
            cmbCategorias.ValueMember = "id";

            ArrayList Cuentas = new ArrayList();
            Cuentas.Add(new CuentaJR("5436423654852", "Luis Alberto Mendoza", 5000));
            Cuentas.Add(new CuentaJR("1234567890123", "Juan Perez Gomez", 4500));
            Cuentas.Add(new CuentaJR("9876543210987", "Maria Lopez Diaz", 3200));
            Cuentas.Add(new CuentaJR("4567891234567", "Carlos Sanchez Ruiz", 7800));
            Cuentas.Add(new CuentaJR("7891234567891", "Ana Garcia Torres", 1500));
            Cuentas.Add(new CuentaJR("3216549873216", "Pedro Martinez Luna", 6200));
            Cuentas.Add(new CuentaJR("6549873216549", "Sofia Hernandez Cruz", 2900));
            Cuentas.Add(new CuentaJR("1472583691472", "Luis Gonzalez Vega", 5100));
            Cuentas.Add(new CuentaJR("2583691472583", "Elena Ramirez Soto", 8700));
            Cuentas.Add(new CuentaJR("3691472583691", "Miguel Castro Nunez", 4300));
            Cuentas.Add(new CuentaJR("7418529637418", "Laura Morales Pena", 6600));
            dtvCategorias.DataSource = Cuentas;
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCategorias seleccionada = cmbCategorias.SelectedItem as clsCategorias;
            //clsCategorias seleccion= (clsCategorias)cmbCategprias.SelectedItem;
            txtid.Text = seleccionada.Id+"";
            txtNombre.Text = seleccionada.Nombre;
            //MessageBox.Show("Hola Cambio el index seleccionado a :" + seleccionada.Id);
        }

        private void chbPOO_CheckedChanged(object sender, EventArgs e)
        {
            if(chbPOO.Checked == false)
            {
                MessageBox.Show("Seguro que no te gusta POO?");
                chbPOO.Checked = true;
            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            lista = "Mis materias favoritas son\n";
            if (chbPOO.Checked)
                lista = lista + "* POO\n";
            if (chbSis.Checked)
                lista += "* sistemas operativos\n";
            if (chbTuto.Checked)
                lista += "* Tutorias\n";
            if (chbWeb.Checked)
                lista += "* Desarrollo web\n";
            MessageBox.Show(lista,"Materias",MessageBoxButtons.OKCancel);

        }

        private void btnfav_Click(object sender, EventArgs e)
        {
            if (rdbPOO.Checked)
                MessageBox.Show("Buena eleccion");
            if (rdbSis.Checked)
                MessageBox.Show("huy si...");
            if (rdbTuto.Checked)
                MessageBox.Show("si te creo...");
            if (rdbWeb.Checked)
                MessageBox.Show("Ni la llevas...");
        }

        private void dtvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                CuentaJR seleccion = (CuentaJR)dtvCategorias.Rows[e.RowIndex].DataBoundItem;
                txtCliente.Text = seleccion.Nombre;
                txtCuenta.Text = seleccion.NumCuenta;
                txtSaldo.Text = "$ " + seleccion.Saldo;
            }
            
        }

        private void dtvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CuentaJR seleccion = (CuentaJR)dtvCategorias.Rows[e.RowIndex].DataBoundItem;
                txtCliente.Text = seleccion.Nombre;
                txtCuenta.Text = seleccion.NumCuenta;
                txtSaldo.Text = "$ " + seleccion.Saldo;
            }
        }

        private void dtvCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CuentaJR seleccion = (CuentaJR)dtvCategorias.Rows[e.RowIndex].DataBoundItem;
                txtCliente.Text = seleccion.Nombre;
                txtCuenta.Text = seleccion.NumCuenta;
                txtSaldo.Text = "$ " + seleccion.Saldo;
            }
        }
    }
}