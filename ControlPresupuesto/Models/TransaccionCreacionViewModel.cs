using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlPresupuesto.Models
{
    public class TransaccionCreacionViewModel: Transaccion
    {

        public IEnumerable<SelectListItem> Cuentas { get; set; }
        public IEnumerable<SelectListItem> Categorias { get; set; }

    }
}
