using AutoMapper;
using LojaVirtual.Aplicacao.ViewModels;
using LojaVirtual.Dominio.Entidades;

namespace LojaVirtual.Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriasViewModel, Categorias>();
        }
    }
}
