using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class DecoradorDescuento : DecoradorProducto
    {
        public DecoradorDescuento(Producto producto) : base(producto)
        {
        }

        public override string ObtenerDescripcion()
        {
            return $"{base.ObtenerDescripcion()} con Descuento";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() * 0.9; 
        }
    }
}
