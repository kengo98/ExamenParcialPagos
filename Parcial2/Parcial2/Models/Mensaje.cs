namespace Parcial2.Models
{
    using Newtonsoft.Json;
    class Mensaje
    {
        [JsonProperty("mensaje")]
        public string mensaje { get; set; }
    }
}

