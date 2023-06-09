using DEPENDENCYINJECTION.DP.DependencyInjectionController;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace DEPENDENCYINJECTION.Controllers
{
    public class OrdenController : Controller
    {
        private readonly IServicioPago _servicioPago;

        public OrdenController(IServicioPago servicioPago)
        {
            _servicioPago = servicioPago;
        }

        public IActionResult Index(double monto)
        {
            _servicioPago.ProcesarPago(monto);
            return View();
        }
    }
}
