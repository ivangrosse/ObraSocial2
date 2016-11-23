using ObraSocialNegocio.ADO;
using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObraSocialWeb.Controllers
{
    public class MedicController
    {
        
        public void AltaMedico(Medico medico, Cuenta cuenta)
        {
            MedicoADO insert = new MedicoADO();
            insert.altaMedico(medico, cuenta);
        }
    }
}