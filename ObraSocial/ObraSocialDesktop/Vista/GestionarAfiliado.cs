﻿using System;
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
    public partial class GestionarAfiliado : Form
    {
        public GestionarAfiliado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionarAfiliado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAfiliados.AFILIADO' table. You can move, or remove it, as needed.
            this.aFILIADOTableAdapter.Fill(this.dataSetAfiliados.AFILIADO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarAfiliado agregarAfiliado = new AgregarAfiliado();
            agregarAfiliado.Show();

        }

      
    }
}
