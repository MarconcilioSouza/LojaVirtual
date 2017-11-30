using System.Collections.Generic;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Infra.Data.EF.Common;

namespace LojaVirtual.Infra.Data.EF.Repositorios
{
    public class RepositorioCategorias : LojaVirtualContext, IRepositorioCategorias
    {
        private LojaVirtualContext ctx = new LojaVirtualContext();

        public void Add(Categorias obj)
        {
            ctx.Categorias.Add(obj);
        }

        public IEnumerable<Categorias> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Categorias GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Categorias obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Categorias obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
