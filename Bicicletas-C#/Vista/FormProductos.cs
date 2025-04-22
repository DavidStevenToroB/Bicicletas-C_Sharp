using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bicicletas_C_.modelos;
using Bicicletas_C_.Controlador;
using System.Drawing.Drawing2D;

namespace Bicicletas_C_.Vista
{
    public class FormProductos : Form
    {
        private ProductoControlador controlador;
        private FlowLayoutPanel contenedorTarjetas;
        private FlowLayoutPanel contenedorBotones;
        private Button btnComprar, btnAll, btnTrail, btnCompeticion, btnTodoTerreno, btnUrban, btnLlantas, btnCuadro, btnManubrio, btnHerramienta, btnCadena, btnNeumatico, btnRines, btnCascos, btnGuantes, btnRopa, btnSuplementos;

        public FormProductos()
        {
            InitializeComponent();
            controlador = new ProductoControlador(this);
            controlador.CargarProductos();
        }

        public void MostrarProductos(List<Producto> productos)
        {
            contenedorTarjetas.Controls.Clear();

            foreach (var producto in productos)
            {
                Panel tarjeta = new Panel
                {
                    Size = new Size(200, 300),
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    BackColor = Color.White
                };

                // Si deseas bordes redondeados, se puede hacer a mano dibujándolos en el evento Paint

                PictureBox pic = new PictureBox
                {
                    Size = new Size(180, 180),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = ConvertirImagen(producto.imagen)
                };
                tarjeta.Controls.Add(pic);

                Label lblNombre = new Label
                {
                    Text = producto.nombre_producto,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 200),
                    AutoSize = true
                };
                tarjeta.Controls.Add(lblNombre);

                Label lblCategoria = new Label
                {
                    Text = $"Categoría: {producto.categoria_producto}",
                    Location = new Point(10, 225),
                    AutoSize = true
                };
                tarjeta.Controls.Add(lblCategoria);

                Label lblPrecio = new Label
                {
                    Text = $"Precio: ${producto.valor_producto:N2}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.DarkGreen,
                    Location = new Point(10, 250),
                    AutoSize = true
                };
                tarjeta.Controls.Add(lblPrecio);

                Button btnAgregar = new Button
                {
                    Text = "Agregar al Carrito",
                    Size = new Size(180, 30),
                    Location = new Point(10, 270),
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat
                };
                tarjeta.Controls.Add(btnAgregar);

                btnAgregar.Click += (sender, e) =>
                {
                    Producto dataProducto = new Producto();
                    dataProducto.AgregarProducto(producto);
                };

                contenedorTarjetas.Controls.Add(tarjeta);
            }
        }

        private Image ConvertirImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void InitializeComponent()
        {
            this.Text = "Catálogo de Productos";
            this.Size = new Size(1000, 700);
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#fff");

            contenedorTarjetas = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(5),
                BackColor = TransparencyKey
            };

            contenedorBotones = new FlowLayoutPanel
            {
                Dock = DockStyle.Right,
                AutoScroll = true,
                WrapContents = false,
                Padding = new Padding(10),
                BackColor = TransparencyKey,
                Width = 180,
                Height = 200
            };

            btnComprar = new Button
            {
                Text = "COMPRAR",
                Size = new Size(200, 30),
                Location = new Point(1150, 20),
                BackColor = Color.LightBlue,
                FlatStyle = FlatStyle.Flat
            };

            btnComprar.Click += (sender, e) =>
            {
                Producto dataProducto = new Producto();
                dataProducto.showCarrito();
            };

            contenedorBotones.FlowDirection = FlowDirection.TopDown;

            btnAll = CrearBoton("All", null);
            btnTrail = CrearBoton("Trail", "trail");
            btnTodoTerreno = CrearBoton("Todo Terreno", "todo terreno");
            btnCompeticion = CrearBoton("Competición", "competición");
            btnUrban = CrearBoton("Urban", "urban");
            btnLlantas = CrearBoton("Llantas", "llantas");
            btnCuadro = CrearBoton("Cuadro", "cuadro");
            btnManubrio = CrearBoton("Manubrio", "manubrio");
            btnHerramienta = CrearBoton("Herramienta", "herramienta");
            btnCadena = CrearBoton("Cadena", "cadena");
            btnNeumatico = CrearBoton("Neumático", "neumático");
            btnRines = CrearBoton("Rines", "rines");
            btnCascos = CrearBoton("Cascos", "cascos");
            btnGuantes = CrearBoton("Guantes", "guantes");
            btnRopa = CrearBoton("Ropa", "ropa");
            btnSuplementos = CrearBoton("Suplementos", "suplementos");

            contenedorBotones.Controls.Add(btnAll);
            contenedorBotones.Controls.Add(btnTrail);
            contenedorBotones.Controls.Add(btnTodoTerreno);
            contenedorBotones.Controls.Add(btnCompeticion);
            contenedorBotones.Controls.Add(btnUrban);
            contenedorBotones.Controls.Add(btnLlantas);
            contenedorBotones.Controls.Add(btnCuadro);
            contenedorBotones.Controls.Add(btnManubrio);
            contenedorBotones.Controls.Add(btnHerramienta);
            contenedorBotones.Controls.Add(btnCadena);
            contenedorBotones.Controls.Add(btnNeumatico);
            contenedorBotones.Controls.Add(btnRines);
            contenedorBotones.Controls.Add(btnCascos);
            contenedorBotones.Controls.Add(btnGuantes);
            contenedorBotones.Controls.Add(btnRopa);
            contenedorBotones.Controls.Add(btnSuplementos);

            this.Controls.Add(btnComprar);
            this.Controls.Add(contenedorTarjetas);
            this.Controls.Add(contenedorBotones);
        }

        private Button CrearBoton(string texto, string categoria)
        {
            Button btn = new Button
            {
                Text = texto,
                Size = new Size(130, 35),
                Margin = new Padding(5),
                BackColor = Color.LightSteelBlue,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Evento para dibujar el borde con el color deseado
            btn.Paint += (sender, e) =>
            {
                Button b = (Button)sender;
                Color bordeColor = ColorTranslator.FromHtml("#0097b2");
                int grosor = 2;

                // Dibujar borde alrededor del botón
                using (Pen pen = new Pen(bordeColor, grosor))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, b.Width - 1, b.Height - 1);
                }
            };

            btn.Click += (sender, e) =>
            {
                controlador.CargarProductos(categoria);
            };

            return btn;
        }
    }
}
