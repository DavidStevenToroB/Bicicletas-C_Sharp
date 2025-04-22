using System.Drawing;
using System;
using System.Windows.Forms;

namespace Bicicletas_C_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnConfiguracion;
        private Button btnCatalogo;

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
            btnConfiguracion = new Button();
            btnCatalogo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderColor = Color.FromArgb(0, 151, 178);
            btnConfiguracion.FlatAppearance.BorderSize = 2;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = Color.FromArgb(0, 151, 178);
            btnConfiguracion.Location = new Point(121, 266);
            btnConfiguracion.Margin = new Padding(6, 7, 6, 7);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(300, 115);
            btnConfiguracion.TabIndex = 0;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.Transparent;
            btnCatalogo.Cursor = Cursors.Hand;
            btnCatalogo.FlatAppearance.BorderColor = Color.FromArgb(0, 151, 178);
            btnCatalogo.FlatAppearance.BorderSize = 3;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.ForeColor = Color.FromArgb(0, 151, 178);
            btnCatalogo.Location = new Point(613, 266);
            btnCatalogo.Margin = new Padding(6, 7, 6, 7);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.RightToLeft = RightToLeft.No;
            btnCatalogo.Size = new Size(300, 115);
            btnCatalogo.TabIndex = 1;
            btnCatalogo.Text = "Catálogo";
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 25);
            label1.Name = "label1";
            label1.Size = new Size(918, 159);
            label1.TabIndex = 2;
            label1.Text = "The Big Wheel";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            WindowState = FormWindowState.Maximized;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 544);
            Controls.Add(label1);
            Controls.Add(btnCatalogo);
            Controls.Add(btnConfiguracion);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Vista Principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // Add the missing event handler method for label1_Click to resolve the CS0103 error.
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your desired logic here. For now, it can be left empty.
        }
        private Label label1;
}
}

