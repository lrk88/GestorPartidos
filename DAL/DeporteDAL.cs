using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeporteDAL
    {
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
    }
}
