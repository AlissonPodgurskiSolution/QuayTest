using System;
using System.Linq;
using Quay.Infra.CrossCutting.Helpers;

namespace Quay.Domain.Entities
{
    public class Previsao
    {
        public int PrevisaoId { get; set; }
        public DateTime Atualizacao { get; set; }
        public DateTime Dia { get; set; }
        public string Tempo { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Minima { get; set; }
        public int Maxima { get; set; }
        public bool Ativo { get; set; }

        public void Ativar()
        {
            Ativo = true;
        }

        public void GravarDescricaoTempo()
        {
            Tempo = SystemValues.SignicadoSiglasTempo.Where(x => x.Key == Tempo).FirstOrDefault().Value;
        }

        public string AtualizacaoFormatada()
        {
            return Atualizacao.ToString("dd/MM/YYYY");
        }
    }
}