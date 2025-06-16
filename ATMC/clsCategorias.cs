using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMC
{
    class clsCategorias
    {
        //atributos
        private int id;
        private string nombre;
        //propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        //coonstructor por parametros
        public clsCategorias(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}
