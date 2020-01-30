using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Quay.Application.ViewModels
{
    [Serializable]
    public class CidadeViewModel
    {
        public CidadeViewModel()
        {
            Previsoes = new List<PrevisaoViewModel>();
        }

        [XmlElement("nome")] public string Nome { get; set; }

        [XmlElement("uf")] public string UF { get; set; }

        [XmlElement("id")] public int Id { get; set; }
        [XmlElement("atualizacao")] public DateTime Atualizacao { get; set; }

        public IList<PrevisaoViewModel> Previsoes { get; set; }
    }
}