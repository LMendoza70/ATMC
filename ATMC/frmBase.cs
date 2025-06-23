using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ATMC
{
    public partial class frmBase : Form
    {
        private clsConeccion coneccion;
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            cargaDatos();

        }

        private void cargaDatos()
        {
            coneccion = new clsConeccion();
            MySqlConnection con = coneccion.getConeccion();

            //comprobamos que se conecto correctamente
            if (con != null)
            {
                MessageBox.Show("Conectado Correctamenete");
                //creamos la consulta
                string consulta = "SELECT nombre,rol_id FROM usuario";
                //creamos un adaptador 
                //creamos un datatable
                //asignamos el datatable al souce del datagrid
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }
    }
}
