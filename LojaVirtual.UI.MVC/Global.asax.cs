using Ninject.Web.Common.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using LojaVirtual.Infra.CrossCutting.IoC.Modulos;
using LojaVirtual.Aplicacao.AutoMapper;

namespace LojaVirtual.UI.MVC
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
        protected override IKernel CreateKernel()
        {
            var modules = new NinjectModule[] { new ModulosNinject() };
            return new StandardKernel(modules);
        }
    }
}
