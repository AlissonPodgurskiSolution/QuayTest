using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Quay.Application.ViewModels;

namespace Quay.Services.CPTEC
{
    public static class PrevisaoCPTEC
    {
        public static IList<PrevisaoViewModel> GetPrevisoes(string parametros)
        {
            var parametrosSplit = parametros.Split('/', '|');
            var url = $"http://servicos.cptec.inpe.br/XML/cidade/7dias/{parametrosSplit.LastOrDefault()}/previsao.xml";

            var xml = XDocument.Load(url);

            var nodesCidade = xml.Descendants("cidade");
            var nodesPrevisao = xml.Descendants("previsao");

            var xElementsCidade = nodesCidade as XElement[] ?? nodesCidade.ToArray();
            var xElementsPrevisao = nodesPrevisao as XElement[] ?? nodesPrevisao.ToArray();
            var listaPrevisaoViewModels = new List<PrevisaoViewModel>();

            Array.ForEach(xElementsCidade, element =>
            {
                var atualizacao = element.Element("atualizacao");

                Array.ForEach(xElementsPrevisao, elementPrevisao =>
                {
                    listaPrevisaoViewModels.Add(new PrevisaoViewModel
                    {
                        Cidade = element.Element("nome").Value,
                        Estado = element.Element("uf").Value,
                        Tempo = elementPrevisao.Element("tempo").Value,
                        Dia = DateTime.Parse(elementPrevisao.Element("dia").Value),
                        Maxima = int.Parse(elementPrevisao.Element("maxima").Value),
                        Minima = int.Parse(elementPrevisao.Element("minima").Value),
                        IUV = double.Parse(elementPrevisao.Element("iuv").Value),
                        Atualizacao = DateTime.Parse(atualizacao.Value)
                    });
                });
            });

            return listaPrevisaoViewModels;
        }
    }
}