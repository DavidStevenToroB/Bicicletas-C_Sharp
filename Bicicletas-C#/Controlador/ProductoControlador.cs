using System.Collections.Generic;
using Bicicletas_C_.modelos;
using Bicicletas_C_.Vista;

namespace Bicicletas_C_.Controlador
{
    public class ProductoControlador
    {
        private FormProductos vista;

        public ProductoControlador(FormProductos form)
        {
            vista = form;
        }

        public void CargarProductos(string categoria = null)
        {
            List<Producto> productos = Producto.ObtenerProductos(categoria);
            vista.MostrarProductos(productos);
        }
    }
}
