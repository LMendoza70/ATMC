using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATMC
{
    public partial class frmLogin : Form
    {
        clsConeccion coneccion;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            int rol=0;

            coneccion = new clsConeccion();
            MySqlConnection con = coneccion.getConeccion();

            string consulta = "select * from usuario where nombre=@nombre";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@nombre", user);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string passHash = reader["password"].ToString();
                rol = Convert.ToInt32( reader["rol_id"]);

                //verificamos que el password coincida
                bool verifica = BCrypt.Net.BCrypt.Verify(pass, passHash);
                if (verifica==true)
                {
                    MessageBox.Show("Acceso correcto");
                    con.Close();
                    this.Hide();
                    frmPrincipal principal = new frmPrincipal(user,rol);
                    principal.Show();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("El password es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe...");
            }

        }
    }
}
