using ControlPresupuesto.Models;
using ControlPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ControlPresupuesto.Controllers
{
    public class CategoriaController: Controller
    {
        private readonly IRepositorioCategorias repositorioCategorias;
        private readonly IServicioUsuarios servicioUsuarios;

        public CategoriaController(IRepositorioCategorias repositorioCategorias, IServicioUsuarios servicioUsuarios)
        {
            this.repositorioCategorias = repositorioCategorias;
            this.servicioUsuarios = servicioUsuarios;
        }

        [HttpGet]
        public IActionResult Crear() 
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Categoria categoria) 
        {

            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            categoria.UsuarioId = usuarioId;
            await repositorioCategorias.Crear(categoria);
            return RedirectToAction("Index");


        }

    }
}
