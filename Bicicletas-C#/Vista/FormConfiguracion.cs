using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bicicletas_C_.Vista
{
    public partial class FormConfiguracion : System.Windows.Forms.Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            //// Abre el formulario Form3
            //Form3 form3 = new Form3();
            //form3.Show();
            //this.Hide(); // Oculta el formulario actual
        }
        
  
        private System.ComponentModel.IContainer components = null;
        private Button btnAtras;
        private Button btnStock;
        private Button btnEmpleado;
        private Button btnFacturas;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAtras = new Button();
            btnStock = new Button();
            btnEmpleado = new Button();
            btnFacturas = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(0, 151, 178);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(20, 20);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(120, 50);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "ATRÁS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += BtnAtras_Click;
            // 
            // btnStock
            // 
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStock.ForeColor = Color.FromArgb(0, 151, 178);
            btnStock.Location = new Point(150, 250);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(150, 75);
            btnStock.TabIndex = 2;
            btnStock.Text = "STOCK";
            btnStock.Click += btnStock_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmpleado.ForeColor = Color.FromArgb(0, 151, 178);
            btnEmpleado.Location = new Point(325, 250);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(150, 75);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "EMPLEADO";
            // 
            // btnFacturas
            // 
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFacturas.ForeColor = Color.FromArgb(0, 151, 178);
            btnFacturas.Location = new Point(500, 250);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(150, 75);
            btnFacturas.TabIndex = 4;
            btnFacturas.Text = "FACTURAS";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Configuración";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(btnStock);
            Controls.Add(btnEmpleado);
            Controls.Add(btnFacturas);
            Name = "Form2";
            Text = "Configuración";
            ResumeLayout(false);
        }
    } 
}
