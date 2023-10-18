using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class EstrategiaDescuentoPorcentaje : IEstrategiaDescuento
    {
        private double _porcentaje;

        public EstrategiaDescuentoPorcentaje(double porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public double AplicarDescuento(double precioOriginal)
        {
            return precioOriginal * (1 - _porcentaje / 100);
        }
    }

}
