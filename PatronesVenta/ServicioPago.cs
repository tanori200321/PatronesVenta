using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class ServicioPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Pago procesado: ${monto}");
        }
    }
}
