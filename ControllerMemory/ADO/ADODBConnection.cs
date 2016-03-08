using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace ControllerCantina.ADO
{
    public sealed class ADODBConnection
    {
        private static volatile SqlConnection instance;

        private ADODBConnection()
        {

        }

        public static SqlConnection Connection()
        {
                if (instance==null)
                {
                    instance=new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoADO"].ConnectionString);
                }
            return instance;
        }
    }
}
