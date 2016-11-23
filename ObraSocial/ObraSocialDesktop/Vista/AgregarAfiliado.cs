using ObraSocialNegocio.ADO;
using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObraSocialDesktop.Vista
{
    public partial class AgregarAfiliado : Form
    {
        public AgregarAfiliado()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Afiliado afiliado = new Afiliado();
                afiliado.Apellido = cApellido.Text;
                afiliado.Nombre = cNombre.Text;
                afiliado.Dni = Int32.Parse(cDni.Text);
                AfiliadoADO.altaAfiliado(afiliado);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo grabar el afiliado" + ex.Message);
            }

            GestionarAfiliado gestion = new GestionarAfiliado();
            gestion.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
