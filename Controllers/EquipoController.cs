using HuertasE_LigaPro.Models;
using HuertasE_LigaPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HuertasE_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
           
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();
           return View(equipos);
        }
    }
}
