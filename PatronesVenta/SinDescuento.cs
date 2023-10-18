using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class SinDescuento : IEstrategiaDescuento
    {
        public double AplicarDescuento(double precioOriginal)
        {
            return precioOriginal;
        }
    }
}
