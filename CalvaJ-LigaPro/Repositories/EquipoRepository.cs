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
        public bool CrearEquipo(Equipo equipo)
        {
            if (Equipos == null)
            {
                Equipos = new List<Equipo>();
            }

            Equipos.Add(equipo);
            return true;
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }
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

        public List<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
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
