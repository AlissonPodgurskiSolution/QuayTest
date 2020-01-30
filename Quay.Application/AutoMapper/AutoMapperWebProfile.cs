using AutoMapper;
using Quay.Application.ViewModels;
using Quay.Domain.Entities;

namespace Quay.Application.AutoMapper
{
    public class AutoMapperWebProfile : Profile
    {
        public AutoMapperWebProfile()
        {
            CreateMap<Previsao, PrevisaoViewModel>();
            CreateMap<PrevisaoViewModel, Previsao>();
        }
    }
}