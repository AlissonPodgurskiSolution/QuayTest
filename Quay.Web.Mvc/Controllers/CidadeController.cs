using System.Web.Mvc;
using Quay.Services.CPTEC;

namespace Quay.Web.Mvc.Controllers
{
    public class CidadeController : Controller
    {
        public JsonResult GetCidades(string nomeCidade)
        {
            var result = CidadeCPTEC.GetCidade(nomeCidade);

            return Json(new {result}, JsonRequestBehavior.AllowGet);
        }
    }
}