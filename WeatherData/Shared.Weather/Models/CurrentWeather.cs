using Newtonsoft.Json;

namespace Shared.Weather.Models
{
    public class CurrentWeather
    {
        [JsonProperty("dt")]
        public DateTime TimeStamp { get; set; }
        public int TimeZone { get; set; }
        [JsonProperty("name")]
        public string City { get; set; } = string.Empty;
        public List<Weather> Weather { get; set; } = new List<Weather>();
        [JsonProperty("main")]
        public MainWeather MainWeather { get; set; } = new MainWeather();
        [JsonProperty("sys")]
        public WeatherSystem WeatherSystem { get; set; } = new WeatherSystem();
    }
}

