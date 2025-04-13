using CalvaJ_LigaPro.Interfaces;
using CalvaJ_LigaPro.Models;

namespace CalvaJ_LigaPro.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public List<Equipo> Equipos;
        public EquipoRepository()
        {
            InicializarEquipos();
        }

        // Inicializa la lista de equipos con equipos por defecto
        public void InicializarEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo idv = new Equipo
            {
                Id = 3,
                Nombre = "Independiente del Valle",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3
            };
            equipos.Add(ldu);
            equipos.Add(barcelona);
            equipos.Add(idv);

            Equipos = equipos;
        }

        // Devuelve la lista de equipos cuando se requiere, con cambios realizados o equipos agregados
        public List<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public bool CrearEquipo(Equipo equipo)
        {
            // Si la lista de equipos es nula, la inicializamos
            if (Equipos == null)
            {
                Equipos = new List<Equipo>();
            }

            // Logica creada por ChatGPT para asignar un nuevo Id al equipo automaticamente desde el programa
            int nuevoId = Equipos.Count > 0 ? Equipos.Max(e => e.Id) + 1 : 1;
            equipo.Id = nuevoId;

            Equipos.Add(equipo);
            return true;
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public bool EditarEquipo(Equipo equipo)
        {
            var index = Equipos.FindIndex(e => e.Id == equipo.Id);
            if (index != -1)
            {
                Equipos[index] = equipo;
                return true;
            }
            return false;
        }

        public bool EliminarEquipo(int id)
        {
            var equipo = DevuelveInfoEquipo(id);
            if (equipo != null)
            {
                Equipos.Remove(equipo);
                return true;
            }
            return false;
        }
    }
}
