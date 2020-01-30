using System;
using System.Xml.Serialization;

namespace Quay.Application.ViewModels
{
    public class PrevisaoViewModel
    {
        [XmlElement("tempo")] public string Tempo { get; set; }

        [XmlElement("cidade")] public string Cidade { get; set; }

        [XmlElement("estado")] public string Estado { get; set; }

        [XmlElement("minima")] public int Minima { get; set; }

        [XmlElement("maxima")] public int Maxima { get; set; }

        [XmlElement("dia")] public DateTime Dia { get; set; }

        [XmlElement("atualizacao")] public DateTime Atualizacao { get; set; }

        [XmlElement("iuv")] public double IUV { get; set; }

        public bool Ativo { get; set; }

        public string DiaFormatado
        {
            get { return this.Dia.ToString("dd/MM/yyyy"); }
        }        
        public string AtualizacaoFormatado
        {
            get { return this.Atualizacao.ToString("dd/MM/yyyy"); }
        }
    }
}