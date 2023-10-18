using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public interface IEstrategiaDescuento
    {
        double AplicarDescuento(double precioOriginal);
    }

}
