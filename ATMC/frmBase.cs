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
                //MessageBox.Show("Conectado Correctamenete");
                //creamos la consulta
                string consulta = "SELECT usuario.id, usuario.nombre, usuario.password, rol.nombre AS rol_name FROM usuario,rol WHERE usuario.rol_id=rol.id";
                //creamos un adaptador 
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                //creamos un datatable
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //asignamos el datatable al souce del datagrid
                dgvDatos.DataSource = dataTable;
                dgvDatos.Columns["id"].Visible = false;

                //llenamos el combo
                string consulta2 = "select * from rol";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                cmbRoles.DataSource = dataTable2;
                cmbRoles.DisplayMember = "nombre";
                cmbRoles.ValueMember = "id";
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void dgvDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString();
                //txtPassword.Text = fila.Cells[2].Value?.ToString();
                cmbRoles.Text = fila.Cells[3].Value?.ToString();
                lblId.Text = fila.Cells["id"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string pass = txtPassword.Text;
            int rolId = Convert.ToInt32(cmbRoles.SelectedValue);

            pass = BCrypt.Net.BCrypt.HashPassword(pass);

            coneccion = new clsConeccion();
            MySqlConnection conn = coneccion.getConeccion();

            string consulta = "INSERT INTO usuario (nombre, password, rol_id)"+
                "VALUES (@nombre, @password, @rol_id)";

            MySqlCommand command = new MySqlCommand(consulta,conn);
            command.Parameters.AddWithValue("@nombre", nom);
            command.Parameters.AddWithValue("@password", pass);
            command.Parameters.AddWithValue("@rol_id",rolId);
            int filasAfectadas= command.ExecuteNonQuery();
            conn.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro extitoso...");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Algo anda mal...");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //vamos a almacenar los datos que quiero editar 
            int id = Convert.ToInt32(lblId.Text);
            string nombre = txtNombre.Text;
            string pass = txtPassword.Text;
            int rol = Convert.ToInt32(cmbRoles.SelectedValue);

            string passwordHash = "";
            if (!string.IsNullOrEmpty(pass))
            {
                passwordHash = BCrypt.Net.BCrypt.HashPassword(pass);
            }

            coneccion = new clsConeccion();
            MySqlConnection con = coneccion.getConeccion();

            string consulta;
            MySqlCommand command;

            if (!string.IsNullOrEmpty(passwordHash))
            {
                consulta = "update usuario set nombre=@nombre, password=@password, rol_id=@rol where id=@id";
                command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@password", passwordHash);
            }
            else
            {
                consulta = "update usuario set nombre=@nombre, rol_id=@rol where id=@id";
                command = new MySqlCommand(consulta, con);
            }
            command.Parameters.AddWithValue("@nombre",nombre);
            command.Parameters.AddWithValue("@rol", rol);
            command.Parameters.AddWithValue("@id",id);

            int filasAfectadas = command.ExecuteNonQuery();
            con.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro editado existosamente...");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Error al actualizar...");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            string nombre = txtNombre.Text;

            DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro de : "+nombre+"?"
                ,"Eliminar",MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                coneccion = new clsConeccion();
                MySqlConnection conn = coneccion.getConeccion();

                string consulta = "delete from usuario where id=@id";
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("@id", id);

                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El usuario se elimino Correctamente...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("No se elimino el usuario");
                }
            }
            catch(MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("El usuario no se elimno por que tiene relacion con otras tablas...");
                }
                else
                {
                    MessageBox.Show("no se pudo por que : " + ex.Message);
                }
                
            }

            
        }
    }
}
