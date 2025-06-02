using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMC
{
    class CuentaEmpresa:Cuenta
    {
        //Atributos
        private string rfc;
        //propiedades
        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }
        //cosntructor
        public CuentaEmpresa() : base()
        {
            nombre = "Cuenta Empresa";
            rfc = "XXXX000000";
        }
        //Metodos
        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && saldo-50 >=cantidad)
            {
                saldo = saldo + cantidad-50;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad >= 1 &&  cantidad <= saldo-50)
            {
                saldo = saldo - cantidad-50;
                return true;
            }
            return false;
        }
    }
}
