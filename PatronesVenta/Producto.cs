using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public abstract class Producto
    {
        public abstract string ObtenerDescripcion();
        public abstract double ObtenerPrecio();
    }
}
