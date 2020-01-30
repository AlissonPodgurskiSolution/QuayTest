using System.Collections.Generic;

namespace Quay.Infra.CrossCutting.Helpers
{
    public static class SystemValues
    {
        public static readonly Dictionary<string, string> SignicadoSiglasTempo;

        static SystemValues()
        {
            SignicadoSiglasTempo = new Dictionary<string, string>();
            SignicadoSiglasTempo.Add("ec", "Encoberto com Chuvas Isoladas");
            SignicadoSiglasTempo.Add("ci", "Chuvas Isoladas");
            SignicadoSiglasTempo.Add("c", "Chuva");
            SignicadoSiglasTempo.Add("in", "Instável");
            SignicadoSiglasTempo.Add("pp", "Possibilidade de Pancadas de Chuva");
            SignicadoSiglasTempo.Add("cm", "Chuva pela Manhã");
            SignicadoSiglasTempo.Add("cn", "Chuva pela Noite");
            SignicadoSiglasTempo.Add("pt", "Pancadas de Chuva a Tarde");
            SignicadoSiglasTempo.Add("pm", "Pancadas de Chuva pela Manhã");
            SignicadoSiglasTempo.Add("np", "Nublado e Pancadas de Chuva");
            SignicadoSiglasTempo.Add("pc", "Pancadas de Chuva");
            SignicadoSiglasTempo.Add("pn", "Parcialmente Nublado");
            SignicadoSiglasTempo.Add("cv", "Chuvisco");
            SignicadoSiglasTempo.Add("ch", "Chuvoso");
            SignicadoSiglasTempo.Add("t", "Tempestade");
            SignicadoSiglasTempo.Add("ps", "Predomínio de Sol");
            SignicadoSiglasTempo.Add("e", "Encoberto");
            SignicadoSiglasTempo.Add("n", "Nublado");
            SignicadoSiglasTempo.Add("cl", "Céu Claro");
            SignicadoSiglasTempo.Add("nv", "Nevoeiro");
            SignicadoSiglasTempo.Add("g", "Geada");
            SignicadoSiglasTempo.Add("ne", "Neve");
            SignicadoSiglasTempo.Add("pnt", "Pancadas de Chuva a Noite");
            SignicadoSiglasTempo.Add("psc", "Possibilidade de Chuva");
            SignicadoSiglasTempo.Add("pcm", "Possibilidade de Chuva pela Manhã");
            SignicadoSiglasTempo.Add("pct", "Possibilidade de Chuva a Tarde");
            SignicadoSiglasTempo.Add("pc:", "Possibilidade de Chuva a Noite");
            SignicadoSiglasTempo.Add("npt", "Nublado com Pancadas a Tarde");
            SignicadoSiglasTempo.Add("npn", "Nublado com Pancadas a Noite");
            SignicadoSiglasTempo.Add("ncn", "Nublado com Possibilidade de Chuva a Noite");
            SignicadoSiglasTempo.Add("nct", "Nublado com Possibilidade de Chuva a Tarde");
            SignicadoSiglasTempo.Add("ncm", "Nublado com Possibilidade de Chuva pela Manhã");
            SignicadoSiglasTempo.Add("npm", "Nublado com Pancadas pela Manhã");
            SignicadoSiglasTempo.Add("npp", "Nublado com Possibilidade de Chuva");
            SignicadoSiglasTempo.Add("vn", "Variação de Nebulosidade");
            SignicadoSiglasTempo.Add("ct", "Chuva a Tarde");
            SignicadoSiglasTempo.Add("ppn", "Possibilidade de Pancadas de Chuva a Noite");
            SignicadoSiglasTempo.Add("ppt", "Possibilidade de Pancadas de Chuva a Tarde");
            SignicadoSiglasTempo.Add("ppm", "Possibilidade de Pancadas de Chuva pela Manhã");
            SignicadoSiglasTempo.Add("lt", "Não Definido");
        }
    }
}