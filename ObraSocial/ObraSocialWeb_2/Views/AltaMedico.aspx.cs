using ObraSocialNegocio.ADO;
using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObraSocialWeb_2.Views
{
    public partial class AltaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAltaMedico_Click(object sender, EventArgs e)
        {


            Medico medico = new Medico();
            Cuenta cuenta = new Cuenta();

            cuenta.Numero = Int32.Parse(txtCuenta.Text);
            cuenta.Banco = txtBanco.Text;

            Especialidad especialidad = new Especialidad();
            especialidad.Descripcion = txtEspecialidad.Text;

            medico.Nombre = txtNombre.Text;
            medico.Apellido = txtApellido.Text;
            medico.Dni = Int32.Parse(txtDni.Text);
            medico.Cuenta = cuenta;
            medico.Especialidad = especialidad;
            medico.Direccion = txtDireccion.Text;

            try
            {
                MedicoADO.altaMedico(medico, cuenta);
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
                
            }
        }

        protected void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}