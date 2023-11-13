using Newtonsoft.Json;
using System;
using System.Text.Json;

namespace Shared.Weather.Models
{
    public class MainWeather
    {
        public float Temp { get; set; }
        [JsonProperty("feels_like")]
        public float Feels { get; set; }
        [JsonProperty("temp_min")]
        public float MinTemp { get; set; }
        [JsonProperty("temp_max")]
        public float MaxTemp { get; set; }
        public int Pressure { get; set; }
        public float Humidity { get; set; }
        [JsonProperty("sea_level")]
        public float SeaLevel { get; set; }
    }
}
