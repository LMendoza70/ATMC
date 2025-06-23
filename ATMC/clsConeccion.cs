using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace ATMC
{
    class clsConeccion
    {
        //declaramos la cadena de coneccion para poder conectar con la base 
        //de datos
        private string cadenaConeccion;

        public clsConeccion()
        {
            cadenaConeccion = "Server=127.0.0.1; Database=ejemplo_clase;Uid=root;Pwd=;Port=3306;";
        }

        public MySqlConnection getConeccion()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConeccion);
                con.Open();
                //MessageBox.Show("Conectado correctamente a la base de datos");
                return con;
                
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Error al conectar con la base de datos...\n error al : "+ ex.Message );
                return null;
            }
        }
    }
}
