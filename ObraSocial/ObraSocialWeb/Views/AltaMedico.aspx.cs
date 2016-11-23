﻿using ObraSocialNegocio.Modelo;
using ObraSocialWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObraSocialWeb.Vista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MedicController controlador = new MedicController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAltaMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            Cuenta cuenta = new Cuenta();
            Especialidad especialidad = new Especialidad();
            medico.Nombre = txtNombre.Text;
            medico.Apellido = txtApellido.Text;
            medico.Dni = Int32.Parse(txtDni.Text);
            medico.Matricula = Int32.Parse(txtMatricula.Text);
            cuenta.Numero = Int32.Parse(txtCuenta.Text);
            medico.Cuenta.Numero = cuenta.Numero;
            especialidad.Descripcion = txtEspecialidad.Text;
            medico.Especialidad.Descripcion = especialidad.Descripcion;
            controlador.Create(medico);
        }
    }
}