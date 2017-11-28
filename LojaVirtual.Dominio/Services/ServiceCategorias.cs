using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Dominio.Interfaces.Services;

namespace LojaVirtual.Dominio.Services
{
    public class ServiceCategorias : ServiceBase<Categorias>, IServiceCategorias
    {
        private readonly IRepositorioCategorias _repositorio;
        public ServiceCategorias(IRepositorioCategorias repositorio) 
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
