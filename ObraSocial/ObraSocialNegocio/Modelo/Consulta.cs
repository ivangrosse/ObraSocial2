using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.Modelo
{
    public class Consulta
    {
        private int id;
        private DateTime fecha;
        private double precio_Reg;
        private Tipo tipo;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public double Precio_Reg
        {
            set
            {
                precio_Reg = value;
            }
            get
            {
                return precio_Reg;
            }
        }

        public DateTime Fecha
        {
            set
            {
                fecha = value;
            }
            get
            {
                return fecha;
            }
        }

        public Tipo Tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return tipo;
            }
        }
    }
}
