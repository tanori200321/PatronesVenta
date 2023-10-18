using PatronesVenta;


ServicioPago servicioPago = new ServicioPago();
IAdaptadorPago adaptadorPago = new AdaptadorPago(servicioPago);

Producto productoBasico = new ProductoBasico();
Producto productoConDescuento = new DecoradorDescuento(productoBasico);

IEstrategiaDescuento estrategiaDescuento = new EstrategiaDescuentoPorcentaje(10); 

Console.WriteLine("Detalles del Producto: " + productoConDescuento.ObtenerDescripcion());
Console.WriteLine("Precio Original: $" + productoConDescuento.ObtenerPrecio());

double precioConDescuento = estrategiaDescuento.AplicarDescuento(productoConDescuento.ObtenerPrecio());
Console.WriteLine("Precio con Descuento: $" + precioConDescuento);

adaptadorPago.ProcesarPago(precioConDescuento);

Console.ReadLine();







