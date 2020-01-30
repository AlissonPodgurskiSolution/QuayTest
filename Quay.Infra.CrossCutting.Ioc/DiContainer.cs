using Quay.Application;
using Quay.Application.Interfaces;
using Quay.Domain.Interfaces.Repositories;
using Quay.Domain.Interfaces.Services;
using Quay.Domain.Services;
using Quay.Infra.Data.Repositories;
using SimpleInjector;

namespace Quay.Infra.CrossCutting.Ioc
{
    public static class DiContainer
    {
        public static Container RegisterDependencies()
        {
            var container = new Container();

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IPrevisaoRepository, PrevisaoRepository>();


            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IPrevisaoService, PrevisaoService>();


            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IPrevisaoAppService, PrevisaoAppService>();

            return container;
        }
    }
}