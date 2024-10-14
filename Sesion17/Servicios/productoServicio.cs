using System;
using System.Collections.Generic;
using System.Linq;
using Sesion17.Modelos;
using System.Text;
using System.Threading.Tasks;

namespace Sesion17.Servicios
{
    internal class productoServicio
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> GetProductos()
        {
            return productos;
        }

        public void EliminarProducto(Producto producto)
        {
            productos.Remove(producto);

        }
    }
}
