using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConfigDB
    {      
        public static string ConnectionString
        {
            get
            {
               
                return ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            }
        }
    }
}
