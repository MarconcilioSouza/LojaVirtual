using AutoMapper;
using LojaVirtual.Aplicacao.ViewModels;
using LojaVirtual.Dominio.Entidades;

namespace LojaVirtual.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           CreateMap<Categorias, CategoriasViewModel>();
        }
    }
}
