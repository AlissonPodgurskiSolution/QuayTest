using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Quay.Application.AutoMapper;
using Quay.Infra.CrossCutting.Ioc;
using SimpleInjector.Integration.Web.Mvc;

namespace Quay.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperWebProfile>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(DiContainer.RegisterDependencies()));
        }
    }
}
