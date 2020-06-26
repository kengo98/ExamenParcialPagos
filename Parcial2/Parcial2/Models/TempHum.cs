﻿
namespace Parcial2.Models
{
    using Newtonsoft.Json;
    public class TempHum
    {
        [JsonProperty("messageId")]
        public string messageId { get; set; }

        [JsonProperty("deviceId")]
        public string deviceId { get; set; }

        [JsonProperty("temperature")]
        public double temperature { get; set; }

        [JsonProperty("humidity")]
        public double humidity { get; set; }
    }
}