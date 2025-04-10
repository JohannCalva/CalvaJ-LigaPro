using CalvaJ_LigaPro.Interfaces;
using CalvaJ_LigaPro.Models;

namespace CalvaJ_LigaPro.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool CrearEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            equipos.Add(ldu);
            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8
            };
            equipos.Add(bsc);
            Equipo idv = new Equipo
            {
                Id = 3,
                Nombre = "Independiente del Valle",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3
            };
            equipos.Add(idv);
            return equipos;
        }

        public bool EditarEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarEquipo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
