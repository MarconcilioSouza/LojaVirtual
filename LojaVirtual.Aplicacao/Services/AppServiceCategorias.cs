using System;
using System.Collections.Generic;
using AutoMapper;
using LojaVirtual.Aplicacao.Interfaces;
using LojaVirtual.Aplicacao.ViewModels;
using LojaVirtual.Aplicacao.AutoMapper;
using LojaVirtual.Dominio.Interfaces.Services;
using LojaVirtual.Dominio.Entidades;

namespace LojaVirtual.Aplicacao.Services
{
    public class AppServiceCategorias : IAppServiceCategorias
    {
        private readonly IServiceCategorias _repositorio;
        private readonly IMapper _mapper;

        public AppServiceCategorias(IServiceCategorias repositorio)
        {
            _repositorio = repositorio;
            _mapper = AutoMapperConfig.Mapper;
        }
        
        public IEnumerable<CategoriasViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoriasViewModel>>(_repositorio.GetAll());
        }

        public CategoriasViewModel GetById(int id)
        {
            return _mapper.Map<CategoriasViewModel>(_repositorio.GetById(id));
        }

        public void Register(CategoriasViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categorias>(customerViewModel);
            _repositorio.Add(categoria);
        }

        public void Update(CategoriasViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categorias>(customerViewModel);
            _repositorio.Update(categoria);
        }

        public void Remove(CategoriasViewModel customerViewModel)
        {
            var categoria = _mapper.Map<Categorias>(customerViewModel);
            _repositorio.Remove(categoria);
        }

        public void Remove(int id)
        {
            _repositorio.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }        
    }
}
