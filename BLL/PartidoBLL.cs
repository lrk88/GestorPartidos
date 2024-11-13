using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PartidoBLL
    {
        private readonly PartidoDAL partidoDAL;
        private readonly DeporteDAL _deporteDAL;


        public PartidoBLL()
        {
            partidoDAL = new PartidoDAL();
            _deporteDAL = new DeporteDAL();
        }

        public List<Partido> ObtenerPartidos()
        {
            return partidoDAL.ObtenerPartidos();
        }
        public List<Deporte> ObtenerDeportes()
        {
            return _deporteDAL.ObtenerDeportes();  
        }
        public Partido ObtenerPartidoPorId(int idPartido)
        {
            return partidoDAL.ObtenerPartidoPorId(idPartido);
        }

        public void GuardarPartido(Partido partido)
        {
            ValidarPartido(partido);
            partido.FechaRegistro = DateTime.Now;
            partidoDAL.InsertarPartido(partido);
        }

        public void ModificarMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            Partido partido = partidoDAL.ObtenerPartidoPorId(idPartido);
            if (partido == null)
                throw new Exception("Partido no encontrado.");

            if (partido.FechaPartido.Date != DateTime.Now.Date)
                throw new Exception("Solo se puede modificar el marcador de partidos que se jueguen hoy.");

            if (marcadorLocal < 0 || marcadorVisitante < 0)
                throw new Exception("El marcador no puede ser menor a cero.");

            partido.MarcadorLocal = marcadorLocal;
            partido.MarcadorVisitante = marcadorVisitante;
            partidoDAL.ActualizarMarcador(partido);
        }

        public void EliminarPartido(int idPartido)
        {
            if (partidoDAL.ObtenerPartidoPorId(idPartido) == null)
                throw new Exception("Partido no encontrado.");

            partidoDAL.EliminarPartido(idPartido);
        }

        private void ValidarPartido(Partido partido)
        {
            if (string.IsNullOrWhiteSpace(partido.EquipoLocal) || partido.EquipoLocal.Length < 5)
                throw new Exception("El nombre del equipo local no puede estar vacío y debe tener al menos 5 caracteres.");

            if (string.IsNullOrWhiteSpace(partido.EquipoVisitante) || partido.EquipoVisitante.Length < 5)
                throw new Exception("El nombre del equipo visitante no puede estar vacío y debe tener al menos 5 caracteres.");
        }
    }
}
