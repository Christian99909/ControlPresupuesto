using ControlPresupuesto.Models;
using ControlPresupuesto.Servicios;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ControlPresupuesto.Controllers
{
    public class TiposCuentasController: Controller
    {
        private readonly string connectionString;
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }
        public IActionResult Crear() 
        {
            
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Crear(TipoCuenta tipoCuenta) 
        {

            if (!ModelState.IsValid) 
            {
                return View(tipoCuenta);

            }

            tipoCuenta.UsuarioId = 1;
            await repositorioTiposCuentas.Crear(tipoCuenta);

            return View();

        }
    }
}
