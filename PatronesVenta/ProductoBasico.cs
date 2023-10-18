using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class ProductoBasico : Producto
    {
        public override string ObtenerDescripcion()
        {
            return "Producto Básico";
        }

        public override double ObtenerPrecio()
        {
            return 50.0;
        }
    }
}
