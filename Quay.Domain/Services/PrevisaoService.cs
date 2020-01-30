using Quay.Domain.Entities;
using Quay.Domain.Interfaces.Repositories;
using Quay.Domain.Interfaces.Services;

namespace Quay.Domain.Services
{
    public class PrevisaoService : ServiceBase<Previsao>, IPrevisaoService
    {
        private readonly IPrevisaoRepository _previsaoRepository;

        public PrevisaoService(IPrevisaoRepository clienteRepository)
            : base(clienteRepository)
        {
            _previsaoRepository = clienteRepository;
        }
    }
}