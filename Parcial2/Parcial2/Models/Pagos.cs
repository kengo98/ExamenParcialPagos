using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.Models
{
    public class Pagos
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("idCliente")]
        public string idCliente { get; set; }

        [JsonProperty("productos")]
        public string[] productos { get; set; }

        [JsonProperty("fecha")]
        public string fecha { get; set; }

        [JsonProperty("montoTotal")]
        public double montoTotal { get; set; }

        [JsonProperty("pagado")]
        public bool pagado { get; set; }
    }
}
