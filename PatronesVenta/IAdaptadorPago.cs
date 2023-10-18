using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public interface IAdaptadorPago
    {
        void ProcesarPago(double monto);
    }
}
