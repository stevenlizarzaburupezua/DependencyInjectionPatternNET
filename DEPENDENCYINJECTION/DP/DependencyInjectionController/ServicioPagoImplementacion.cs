namespace DEPENDENCYINJECTION.DP.DependencyInjectionController
{
    public class ServicioPagoImplementacion : IServicioPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago por {monto} dólares");
        }
    }
}
