﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.Modelo
{
    class Especialidad
    {
        private String descripcion;

        public String Descripcion
        {
            set
            {
                descripcion = value;
            }
            get
            {
                return descripcion;
            }
        }
    }
}
