using LojaVirtual.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LojaVirtual.Aplicacao.Interfaces
{
    public interface IAppServiceCategorias : IDisposable
    {
        void Register(CategoriasViewModel customerViewModel);
        IEnumerable<CategoriasViewModel> GetAll();
        CategoriasViewModel GetById(int id);
        void Update(CategoriasViewModel customerViewModel);
        void Remove(int id);
        void Remove(CategoriasViewModel id);
       // IEnumerable<CategoriasViewModel> Find(Expression<Func<CategoriasViewModel, bool>> predicate);
    }
}
