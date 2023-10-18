using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesVenta
{
    public class AdaptadorPago : IAdaptadorPago
    {
        private ServicioPago _servicioPago;

        public AdaptadorPago(ServicioPago servicioPago)
        {
            _servicioPago = servicioPago;
        }

        public void ProcesarPago(double monto)
        {
            _servicioPago.ProcesarPago(monto);
        }
    }
}
