using System;

namespace HistoricoClimatologico.Database
{
    public class Historico : BaseEntity
    {
        public DateTime DataConsulta { get; set; }
        public string Base { get; set; }
        public int Visibilidade { get; set; }
        public int Data { get; set; }
        public int Timezone { get; set; }
        public string NomeCidade { get; set; }
        public int CodigoCidade { get; set; }
        public float Temperatura { get; set; }
        public float Umidade { get; set; }
    }

    public class HistoricoMedia
    {
        public DateTime Data { get; set; }
        public string NomeCidade { get; set; }
        public float TemperaturaMedia { get; set; }
        public float UmidadeMedia { get; set; }
    }
}
