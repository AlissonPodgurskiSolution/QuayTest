using System.Collections.Generic;
using System.Web.Mvc;
using Quay.Application.Interfaces;
using Quay.Application.ViewModels;
using Quay.Services.CPTEC;

namespace Quay.Web.Mvc.Controllers
{
    public class PrevisaoController : Controller
    {
        private readonly IPrevisaoAppService _previsaoAppService;

        public PrevisaoController(IPrevisaoAppService previsaoAppService)
        {
            _previsaoAppService = previsaoAppService;
        }

        public JsonResult GetPrevisoes(string parametros)
        {
            var listaPrevisaoViewModels = new List<PrevisaoViewModel>();
            if (parametros.Split('/', '|').Length == 4)
                foreach (var previsaoViewModel in PrevisaoCPTEC.GetPrevisoes(parametros))
                    listaPrevisaoViewModels.Add(_previsaoAppService.InserirPrevisao(previsaoViewModel));

            return Json(new {listaPrevisaoViewModels}, JsonRequestBehavior.AllowGet);
        }
    }
}