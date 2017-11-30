using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Infra.Data.EF.Common;

namespace ProjetoModelo.Infra.Data.EF.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected LojaVirtualContext db = new LojaVirtualContext();
        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }
        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = GetById(id);
            Remove(obj);
        }
        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            db.Dispose();
        }        
    }
}
