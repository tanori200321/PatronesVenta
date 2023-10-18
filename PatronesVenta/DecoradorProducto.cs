using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public abstract class DecoradorProducto : Producto
    {
        protected Producto _producto;

        public DecoradorProducto(Producto producto)
        {
            _producto = producto;
        }

        public override string ObtenerDescripcion()
        {
            return _producto.ObtenerDescripcion();
        }

        public override double ObtenerPrecio()
        {
            return _producto.ObtenerPrecio();
        }
    }
}
