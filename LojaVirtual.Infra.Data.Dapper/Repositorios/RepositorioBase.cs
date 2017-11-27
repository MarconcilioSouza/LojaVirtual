using Dapper.Contrib.Extensions;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Infra.Data.Dapper.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LojaVirtual.Infra.Data.Dapper.Repositorios
{
    public class RepositorioBase<TEntity> : LojaVirtualSqlConnection, IRepositorioBase<TEntity>, IDisposable where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var conn = SqlConnectionDapper)
            {
                conn.Insert<TEntity>(entity);
            }
        }

        public IEnumerable<TEntity> All()
        {
            using (var conn = SqlConnectionDapper)
            {
                return conn.GetAll<TEntity>().ToList();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var conn = SqlConnectionDapper)
            {
                conn.Delete<TEntity>(entity);
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            using (var conn = SqlConnectionDapper)
            {
                return conn.Get<TEntity>(id);
            }
        }

        public void Update(TEntity entity)
        {
            using (var conn = SqlConnectionDapper)
            {
                conn.Update<TEntity>(entity);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
