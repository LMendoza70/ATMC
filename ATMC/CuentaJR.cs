using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMC
{
    class CuentaJR:Cuenta
    {
        //Atributos
        //propiedades
        //cosntructor
        public CuentaJR():base()
        {
            nombre = "Cuenta JR";
        }
        public CuentaJR(string NC,string nom,float sal)
        {
            numCuenta = NC;
            nombre = nom;
            saldo = sal;
        }
        //Metodos
        public override bool Deposito(float cantidad)
        {
            if(cantidad>=1 && cantidad<=5000 && saldo + cantidad <= 25000)
            {
                saldo = saldo + cantidad;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if(cantidad>=1 && cantidad <=5000 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                return true;
            }
            return false;
        }
        
    }
}
