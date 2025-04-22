using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicicletas_C_.Controlador;
using Bicicletas_C_.Vista;
using MySql.Data.MySqlClient;


namespace Bicicletas_C_.modelos
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string categoria_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string atributos_producto { get; set; }
        public int stock { get; set; }
        public double valor_producto { get; set; }
        public byte[] imagen { get; set; }

        private static string cadenaConexion = "server=localhost;user=root;password=;database=thebigwheel;";
        private static List<Producto> productosCarrito = new List<Producto>();

        public static List<Producto> ObtenerProductos(string categoria)
        {
            List<Producto> productos = new List<Producto>();
            


            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT * FROM producto";
                if (!string.IsNullOrEmpty(categoria))
                {
                    query = "SELECT * FROM producto WHERE categoria_producto = @categoria";
                }

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    if (!string.IsNullOrEmpty(categoria))
                    {
                        comando.Parameters.AddWithValue("@categoria", categoria);
                    }

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                id_producto = reader.GetInt32("id_producto"),
                                categoria_producto = reader.GetString("categoria_producto"),
                                nombre_producto = reader.GetString("nombre_producto"),
                                descripcion_producto = reader.GetString("descripcion_producto"),
                                atributos_producto = reader.GetString("atributos_producto"),
                                stock = reader.GetInt32("stock"),
                                valor_producto = reader.GetDouble("valor_producto"),
                                imagen = (byte[])reader["imagen"]
                            });
                        }
                    }
                }
            }
            return productos;
        }

        public static void MostrarCategoria(string categoria)
        {
            FormProductos formProductos = new FormProductos();
            ProductoControlador productoControlador = new ProductoControlador(formProductos);
            productoControlador.CargarProductos(categoria);
        }

        public void AgregarProducto(Producto data)
        {
            MessageBox.Show("Producto agregado correctamente : \n" + data.nombre_producto);
            productosCarrito.Add(data);

        }

        public void showCarrito()
        {
            if (productosCarrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            string mensaje = "🛒 Productos en el carrito:\n\n";
            double sumaTotal = 0;

            foreach (var producto in productosCarrito)
            {
                mensaje +=
                    "• Categoría: " + producto.categoria_producto + "\n" +
                    "• Nombre: " + producto.nombre_producto + "\n" +
                    "• Valor: $" + producto.valor_producto +"\n" +
                    "--------------------------\n";

                sumaTotal += producto.valor_producto;
            }

            FormVenta venta = new FormVenta(mensaje, sumaTotal);
            venta.Show();
                

        }

        public void confirmarVenta()
        {
            DialogResult dialogResult = MessageBox.Show(
                "¿Deseas finalizar la compra?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("se aguardado la venta con exito");
            }
        }


    }
}
