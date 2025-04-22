using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Collections;
using Bicicletas_C_.Vista;

namespace Bicicletas_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Método para manejar el evento Click del botón Configuración
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Lógica para abrir Form2
            FormConfiguracion configuracionForm = new FormConfiguracion();
            configuracionForm.Show();
        }
        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            var ventanaProductos = new Vista.FormProductos();
            ventanaProductos.Show();
        }


            //Método para manejar el evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}