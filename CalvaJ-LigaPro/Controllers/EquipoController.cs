using CalvaJ_LigaPro.Models;
using CalvaJ_LigaPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CalvaJ_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        //El nombre debe coincidir con la vista relacionada al controlador "Lista equipos"
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();
            return View(equipos);
        }
        //Investigar 
        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
    }
}
