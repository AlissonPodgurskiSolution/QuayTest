using System;
using AutoMapper;
using Quay.Application.Interfaces;
using Quay.Application.ViewModels;
using Quay.Domain.Entities;
using Quay.Domain.Interfaces.Services;

namespace Quay.Application
{
    public class PrevisaoAppService : AppServiceBase<Previsao>, IPrevisaoAppService
    {
        private readonly IPrevisaoService _previsaoService;


        public PrevisaoAppService(IPrevisaoService previsaoService)
            : base(previsaoService)
        {
            _previsaoService = previsaoService;
        }

        public PrevisaoViewModel InserirPrevisao(PrevisaoViewModel previsaoViewModel)
        {
            var previsao = Mapper.Map<PrevisaoViewModel, Previsao>(previsaoViewModel);
            previsao.Atualizacao = DateTime.Now;
            previsao.Ativar();
            previsao.GravarDescricaoTempo();
            _previsaoService.Add(previsao);
            return Mapper.Map<Previsao, PrevisaoViewModel>(previsao);
        }
    }
}