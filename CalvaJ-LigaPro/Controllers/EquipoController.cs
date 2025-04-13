using CalvaJ_LigaPro.Models;
using CalvaJ_LigaPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CalvaJ_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        //Cambio sugerido por ChatGPT para no instanciar el repositorio varias veces en el controlador
        private readonly EquipoRepository _repository;
        public EquipoController(EquipoRepository repository)
        {
            _repository = repository;
        }

        //El nombre debe coincidir con la vista relacionada al controlador "Lista equipos"
        public IActionResult ListaEquipos()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        // Obtiene los detalles del equipo seleccionado para editar
        public IActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }

        // Recibe los cambios realizados en la vista de editar y los guarda
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Equipo equipo)
        {
            try
            {
                _repository.EditarEquipo(equipo);
                return RedirectToAction("ListaEquipos");
            }
            catch
            {
                return View();
            }
        }

        // Vista para crear un nuevo equipo
        public IActionResult Create()
        {
            return View();
        }

        // Recibe los datos del nuevo equipo y lo guarda
        //POST: EquipoController/Create sacado de una plantilla Controlador que permite las operaciones CRUD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Equipo equipo)
        {
            try
            {
                _repository.CrearEquipo(equipo);
                return RedirectToAction("ListaEquipos");
            }
            catch
            {
                return View();
            }
        }

        // Vista para eliminar un equipo como advertencia
        public ActionResult Delete(int Id)
        {
            var equipo = _repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }

        // Recibe la confirmación de eliminación y elimina el equipo
        // Post: EquipoController/Delete/5 sacado de la plantilla de controlador que permite las operaciones CRUD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Equipo equipo)
        {
            try
            {
                _repository.EliminarEquipo(id);
                return RedirectToAction("ListaEquipos");
            }
            catch
            {
                return View();
            }
        }
    }
}
