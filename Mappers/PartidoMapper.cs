using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class PartidoMapper
    {
        public Partido Map(SqlDataReader reader)
        {
            return new Partido
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID_PARTIDO")),
                EquipoLocal = reader.GetString(reader.GetOrdinal("EQUIPO_LOCAL")),
                EquipoVisitante = reader.GetString(reader.GetOrdinal("EQUIPO_VISITANTE")),
                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FECHA_REGISTRO")),
                FechaPartido = reader.GetDateTime(reader.GetOrdinal("FECHA_PARTIDO")),
                MarcadorLocal = reader.GetInt32(reader.GetOrdinal("MARCADOR_LOCAL")),
                MarcadorVisitante = reader.GetInt32(reader.GetOrdinal("MARCADOR_VISITANTE")),
                Deporte = new Deporte
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID_DEPORTE")),
                    Descripcion = reader.GetString(reader.GetOrdinal("DESCRIPCION"))
                }
            };
        }
    }
}
