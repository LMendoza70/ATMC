using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMC
{
    class CuentaFree:Cuenta
    {
        //Atributos
        //propiedades
        //cosntructor
        public CuentaFree() : base()
        {
            nombre = "Cuenta Free";
        }
        //Metodos
        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 9000)
            {
                saldo = saldo + cantidad;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 9000 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                return true;
            }
            return false;
        }
    }
}
