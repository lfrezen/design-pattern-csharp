using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class PontoCnh
    {
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public int Pontos { get; set; }
    }
}
