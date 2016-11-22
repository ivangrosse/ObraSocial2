using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.Modelo
{
    class Medico
    {
        private int matricula;
        private String nombre;
        private String apellido;
        private int dni;
        private String direccion;
        List<Consulta> consultas = new List<Consulta>();
        private Cuenta cuenta;
        private Especialidad especialidad;

        public int Matricula
        {
            set
            {
                matricula = value;
            }
            get
            {
                return matricula;
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
        
        public String Direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
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
        public void agregarConsulta(Consulta c)
        {
            consultas.Add(c);
        }

        public Cuenta Cuenta
        {
            set
            {
                cuenta = value;
            }
            get
            {
                return cuenta;
            }
        }

        public Especialidad Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }

    }
}
