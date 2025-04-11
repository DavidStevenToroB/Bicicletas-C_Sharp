using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Bicicletas_C_
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=thebigwhee; uid=root; pwd=;");

        public Form1()
        {
            InitializeComponent();
            VerificarConexion();
        }

        private void VerificarConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión Exitosa");
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexión a MySQL: " + ex.Message + "\nCódigo de error: " + ex.Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
