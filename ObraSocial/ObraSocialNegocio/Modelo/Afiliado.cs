using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.Modelo
{
    public class Afiliado
    {
        private int numero;
        private int dni;
        private String nombre;
        private String apellido;
        List<Consulta> consultas = new List<Consulta>();

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

        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public String Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public String Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }

        public void agregarConsulta(Consulta c)
        {
            consultas.Add(c);
        }
    }
}
