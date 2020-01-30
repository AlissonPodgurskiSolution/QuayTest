using Quay.Application.ViewModels;
using Quay.Domain.Entities;

namespace Quay.Application.Interfaces
{
    public interface IPrevisaoAppService : IAppServiceBase<Previsao>
    {
        PrevisaoViewModel InserirPrevisao(PrevisaoViewModel previsaoViewModel);
    }
}