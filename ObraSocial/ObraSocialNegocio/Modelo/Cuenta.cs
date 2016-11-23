using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.Modelo
{
    public class Cuenta
    {
        private int numero;
        private String banco;

        public int Numero
        {
            set
            {
                numero = value;
            }
            get
            {
                return numero;
            }
        }

        public String Banco {
            set
            {
                banco = value;
            }
            get
            {
                return banco;
            }
        }
    }
}
