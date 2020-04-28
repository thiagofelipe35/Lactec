using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HistoricoClimatologico.Models
{
    public class ClimaModel
    {
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("visibility")]
        public int Visibilidade { get; set; }
        [JsonProperty("dt")]
        public int Data { get; set; }
        [JsonProperty("timezone")]
        public int Timezone { get; set; }
        [JsonProperty("id")]
        public int CodigoCidade { get; set; }
        [JsonProperty("name")]
        public string NomeCidade { get; set; }
        [JsonProperty("cod")]
        public int Codigo { get; set; }

        [JsonProperty("coord")]
        public Coordenadas Coordenadas { get; set; }
        [JsonProperty("weather")]
        public List<Clima> Clima { get; set; }
        [JsonProperty("main")]
        public Principal Principal { get; set; }
        [JsonProperty("wind")]
        public Vento Vento { get; set; }
        [JsonProperty("clouds")]
        public Nuvens Nuvens { get; set; }
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
    }

    [JsonObject("coord")]
    public class Coordenadas
    {
        [JsonProperty("lon")]
        public float Longitude { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
    }

    [JsonObject("weather")]
    public class Clima
    {
        [JsonProperty("id")]
        public float Id { get; set; }
        [JsonProperty("main")]
        public string Tempo { get; set; }
        [JsonProperty("description")]
        public string Descricao { get; set; }
        [JsonProperty("icon")]
        public string Icone { get; set; }
    }

    [JsonObject("main")]
    public class Principal
    {
        [JsonProperty("temp")]
        public float Temperatura { get; set; }
        [JsonProperty("feels_like")]
        public float Sensacao { get; set; }
        [JsonProperty("temp_min")]
        public float TemperaturaMinima { get; set; }
        [JsonProperty("temp_max")]
        public float TemperaturaMaxima { get; set; }
        [JsonProperty("pressure")]
        public float PressaoAtmosferica { get; set; }
        [JsonProperty("humidity")]
        public float Umidade { get; set; }
    }

    [JsonObject("wind")]
    public class Vento
    {
        [JsonProperty("speed")]
        public float Velocidade { get; set; }
        [JsonProperty("deg")]
        public float Angulo { get; set; }
    }

    [JsonObject("clouds")]
    public class Nuvens
    {
        [JsonProperty("all")]
        public int Tipo { get; set; }
    }

    [JsonObject("sys")]
    public class Sys
    {
        [JsonProperty("type")]
        public int Tipo { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("country")]
        public string Pais { get; set; }
        [JsonProperty("sunrise")]
        public int NascerDoSol { get; set; }
        [JsonProperty("sunset")]
        public int PorDoSol { get; set; }
    }
}
