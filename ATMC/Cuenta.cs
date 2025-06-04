using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMC
{
    abstract class Cuenta
    {
        //Atributos
        protected string numCuenta;
        protected string nombre;
        protected float saldo;
        //propiedades

        public string NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Saldo
        {
            get { return saldo; }
        }

        //cosntructor
        public Cuenta()
        {
            numCuenta = "00000000";
            nombre = "Cuenta";
            saldo = 10000;
        }
        //metodos
        abstract public bool Deposito(float cantidad);
        abstract public bool Retiro(float cantidad);
        public string Estado()
        {
            return "La cuenta : " + numCuenta + "\nde : " + nombre + "\nTiene : $" + saldo;
        }
    }
}
