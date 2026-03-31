using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlPresupuesto.Models
{
    public class CuentaCreacionViewModel: Cuenta
    {

        public IEnumerable<SelectListItem> TiposCuentas { get; set; }

    }
}
