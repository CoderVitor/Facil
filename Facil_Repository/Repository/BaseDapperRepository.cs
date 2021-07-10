using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_Repository.Repository
{
    public class BaseDapperRepository
    {
        public static IDbConnection Connection => new SqlConnection(ConfigurationManager.ConnectionStrings["cnnStringCliente"].ConnectionString);
    }
}
