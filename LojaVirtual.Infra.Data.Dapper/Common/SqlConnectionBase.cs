using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LojaVirtual.Infra.Data.Dapper.Common
{
    public class SqlConnectionBase : IDisposable
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LojaVirtual"].ConnectionString;

        public IDbConnection CreateConnection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
