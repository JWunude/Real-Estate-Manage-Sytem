using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lems.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;
 
        public DbConnection()
        {
            //For dasborad Implementation
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LemsDBCn"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
