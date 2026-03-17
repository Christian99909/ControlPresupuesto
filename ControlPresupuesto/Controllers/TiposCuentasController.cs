using Microsoft.AspNetCore.Mvc;

namespace ControlPresupuesto.Controllers
{
    public class TiposCuentasController: Controller
    {
        public IActionResult Crear() 
        {
            return View();

        }
    }
}
