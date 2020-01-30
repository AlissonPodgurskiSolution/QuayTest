using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Quay.Application.ViewModels;

namespace Quay.Services.CPTEC
{
    public static class CidadeCPTEC
    {
        public static List<CidadeViewModel> GetCidade(string nomeCidade)
        {
            var url = "http://servicos.cptec.inpe.br/XML/listaCidades?city=" + nomeCidade;

            var xml = XDocument.Load(url);

            var nodes = xml.Descendants("cidade");

            var xElements = nodes as XElement[] ?? nodes.ToArray();
            var listaCidadeViewModels = new List<CidadeViewModel>();

            Array.ForEach(xElements, element =>
            {
                var uf = element.Element("uf");
                var nome = element.Element("nome");
                var id = element.Element("id");

                listaCidadeViewModels.Add(new CidadeViewModel
                {
                    Id = int.Parse(id.Value),
                    Nome = nome.Value,
                    UF = uf.Value
                });
            });

            var result = listaCidadeViewModels.Distinct().Take(10).ToList();
            return result;
        }

    }
}