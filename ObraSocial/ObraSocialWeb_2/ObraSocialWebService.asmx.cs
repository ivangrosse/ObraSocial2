using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ObraSocialWeb_2
{
    /// <summary>
    /// Summary description for ObraSocialWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ObraSocialWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string validarAfiliado(int nroAfiliado)
        {

            Afiliado afiliado = new Afiliado();
            afiliado = ObraSocialNegocio.ADO.AfiliadoADO.buscarAfiliado(nroAfiliado);
            if (afiliado == null)
            {
                return "No se encontro el afiliado";
            }
            return afiliado.Nombre + " " + afiliado.Apellido + " es afiliado";
        }
    }
}
