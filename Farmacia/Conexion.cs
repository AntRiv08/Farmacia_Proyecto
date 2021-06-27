using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farmacia
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-K33EK4L;Initial Catalog=db_Sfarmacia;Integrated Security=True");
            cn.Open();
            return cn;
        }
    }
}
