using System.Collections.Generic;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Infra.Data.EF.Common;
using System.Linq;
using System;
using System.Data.Entity;

namespace LojaVirtual.Infra.Data.EF.Repositorios
{
    public class RepositorioCategorias : IDisposable, IRepositorioCategorias
    {
        LojaVirtualContext ctx = new LojaVirtualContext();
        public void Add(Categorias obj)
        {
            ctx.Categorias.Add(obj);
            ctx.SaveChanges();
        }

        public IEnumerable<Categorias> GetAll()
        {
            return ctx.Categorias.ToList();
        }

        public Categorias GetById(int id)
        {
            return ctx.Categorias.Find(id);
        }

        public void Remove(int id)
        {
            var categoria = ctx.Categorias.Find(id);
            Remove(categoria);
        }

        public void Remove(Categorias obj)
        {
            ctx.Categorias.Remove(obj);
            ctx.SaveChanges();
        }

        public void Update(Categorias obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
