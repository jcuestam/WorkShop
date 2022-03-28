using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    internal class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.connection);
            conexion.Open();
            return conexion;
        }

    }
}
