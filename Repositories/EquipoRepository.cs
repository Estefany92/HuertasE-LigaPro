using HuertasE_LigaPro.Models;

namespace HuertasE_LigaPro.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                Totalpuntos = 30
            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 9,
                Totalpuntos = 3
            };

            equipos.Add(ldu);
            equipos.Add(bsc);

            return equipos;
        }
    }
}
