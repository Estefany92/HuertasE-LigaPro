using HuertasE_LigaPro.Models;

namespace HuertasE_LigaPro.Repositories
{
    public class EquipoRepository

    {
        //lista estatica para que se mantengan los datos incluso si se cierra o actualiza todo
        private static List<Equipo> _equipos;

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {

            if (_equipos != null)
                return _equipos.OrderBy(e => e.Totalpuntos).ToList();

            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
                
            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 9
                
            };

            equipos.Add(ldu);
            equipos.Add(bsc);

            _equipos = equipos;

            return _equipos.OrderBy(e => e.Totalpuntos).ToList();

        }
        public Equipo DevuelveInformacionEquipo(int Id)
        {
            var equipos= DevuelveListadoEquipos();
            var equipo= equipos.First(item => item.Id == Id);

            return equipo;
       
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var index = _equipos.FindIndex(e => e.Id == equipo.Id);
            if (index != -1)
            {
                _equipos[index].Nombre = equipo.Nombre;
                _equipos[index].PartidosJugados = equipo.PartidosJugados;
                _equipos[index].PartidosGanados = equipo.PartidosGanados;
                _equipos[index].PartidosEmpatados = equipo.PartidosEmpatados;
                _equipos[index].PartidosPerdidos = equipo.PartidosPerdidos;
                return true;
            }
            return false;
        }
    }
}
