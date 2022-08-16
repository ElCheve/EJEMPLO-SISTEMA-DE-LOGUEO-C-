using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogueoRecolector
{
    public class Conexionbd
    {
        public static SqlConnection ConectarBD()
        {
            SqlConnection connectionn = new SqlConnection("Data Source=DESKTOP-INI87OF; Initial Catalog =EmpleadoCafetal; Integrated Security = True");
            connectionn.Open();
            return connectionn;

        }



    }
}
