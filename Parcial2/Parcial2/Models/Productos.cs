using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.Models
{
    public class Productos
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("precio")]
        public double precio { get; set; }

        [JsonProperty("imagen")]
        public String imagen { get; set; }

    }
}
