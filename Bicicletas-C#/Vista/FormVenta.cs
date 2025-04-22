using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicicletas_C_.modelos;

namespace Bicicletas_C_.Vista
{
    public partial class FormVenta : Form
    {
        public FormVenta(string mensaje, double total)
        {

            this.Text = "\U0001f6d2 Carrito:";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 700);
            this.BackColor = Color.LightGray;

            Label lblEmpleado = new Label
            {
                Text = "Clave:",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(250, 10),
                AutoSize = true
            };
            this.Controls.Add(lblEmpleado);

            TextBox txtUsuario = new TextBox
            {
                Location = new Point(250, 30),
                Width = 130
            };
            this.Controls.Add(txtUsuario);

            Label lblVenta = new Label
            {
                Text = $"{mensaje} Total = {total}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(15, 10),
                AutoSize = true
            };
            this.Controls.Add(lblVenta);
        }
    }
}
