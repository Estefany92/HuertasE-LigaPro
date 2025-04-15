using HuertasE_LigaPro.Models;
using HuertasE_LigaPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HuertasE_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        //lo cambia privado para que solo lo vea el programador y mejorar
        private readonly EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public IActionResult List()
        {
           
            var equipos = _repository.DevuelveListadoEquipos();
           return View(equipos);
        }

        [HttpGet]
        public IActionResult EditarEquipo(int Id)
        {
            
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            return View(equipo);
        }

        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            var actualizado = _repository.ActualizarEquipo(equipo);
            if (actualizado)
            {
                return RedirectToAction("List");
            }
            return View(equipo);
        }


        public IActionResult DetalleEquipo(int id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(id);
            return View(equipo); 
        }

    }
}
