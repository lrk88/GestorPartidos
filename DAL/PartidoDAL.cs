using Entity;
using Mappers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartidoDAL
    {
        private readonly string connectionString;
        private readonly PartidoMapper partidoMapper;

        public PartidoDAL()
        {
            connectionString = ConfigDB.ConnectionString;
            partidoMapper = new PartidoMapper();
        }

        public List<Deporte> ObtenerDeportes()
        {
            List<Deporte> deportes = new List<Deporte>();
            string query = "SELECT ID_DEPORTE, DESCRIPCION FROM DEPORTE";

            using (SqlConnection con = new SqlConnection(ConfigDB.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deporte deporte = new Deporte
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID_DEPORTE")),
                                Descripcion = reader.GetString(reader.GetOrdinal("DESCRIPCION"))
                            };
                            deportes.Add(deporte);
                        }
                    }
                }
            }
            return deportes;
        }

        public List<Partido> ObtenerPartidos()
        {
            List<Partido> partidos = new List<Partido>();
            string query = "SELECT p.ID_PARTIDO, p.EQUIPO_LOCAL, p.EQUIPO_VISITANTE, p.FECHA_REGISTRO, p.FECHA_PARTIDO, p.MARCADOR_LOCAL, p.MARCADOR_VISITANTE, d.ID_DEPORTE, d.DESCRIPCION " +
                           "FROM PARTIDO p JOIN DEPORTE d ON p.ID_DEPORTE = d.ID_DEPORTE";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            partidos.Add(partidoMapper.Map(reader));
                        }
                    }
                }
            }
            return partidos;
        }

        public Partido ObtenerPartidoPorId(int idPartido)
        {
            Partido partido = null;
            string query = "SELECT p.ID_PARTIDO, p.EQUIPO_LOCAL, p.EQUIPO_VISITANTE, p.FECHA_REGISTRO, p.FECHA_PARTIDO, p.MARCADOR_LOCAL, p.MARCADOR_VISITANTE, d.ID_DEPORTE, d.DESCRIPCION " +
                           "FROM PARTIDO p JOIN DEPORTE d ON p.ID_DEPORTE = d.ID_DEPORTE WHERE p.ID_PARTIDO = @IdPartido";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdPartido", idPartido);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            partido = partidoMapper.Map(reader);
                        }
                    }
                }
            }
            return partido;
        }

        public void InsertarPartido(Partido partido)
        {
           
            if (partido.Deporte == null || partido.Deporte.ID <= 0)
            {
                throw new Exception("El deporte no es válido.");
            }

            string query = "INSERT INTO PARTIDO (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE) " +
                           "VALUES (@IdDeporte, @EquipoLocal, @EquipoVisitante, @FechaRegistro, @FechaPartido, @MarcadorLocal, @MarcadorVisitante)";

            using (SqlConnection con = new SqlConnection(ConfigDB.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdDeporte", partido.Deporte.ID);  
                    cmd.Parameters.AddWithValue("@EquipoLocal", partido.EquipoLocal);
                    cmd.Parameters.AddWithValue("@EquipoVisitante", partido.EquipoVisitante);
                    cmd.Parameters.AddWithValue("@FechaRegistro", partido.FechaRegistro);
                    cmd.Parameters.AddWithValue("@FechaPartido", partido.FechaPartido);
                    cmd.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                    cmd.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarMarcador(Partido partido)
        {
            string query = "UPDATE PARTIDO SET MARCADOR_LOCAL = @MarcadorLocal, MARCADOR_VISITANTE = @MarcadorVisitante WHERE ID_PARTIDO = @IdPartido";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                    cmd.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);
                    cmd.Parameters.AddWithValue("@IdPartido", partido.ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPartido(int idPartido)
        {
            string query = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @IdPartido";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdPartido", idPartido);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

