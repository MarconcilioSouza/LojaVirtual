using System;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;

namespace LojaVirtual.Infra.Data.Dapper.Common
{
    public class LojaVirtualSqlConnection : IDisposable
    {
        public IDbConnection SqlConnectionDapper
        {
            get { return new SqlCeConnection(ConfigurationManager.ConnectionStrings["LojaVirtual"].ConnectionString); }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
