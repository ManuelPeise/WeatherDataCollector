namespace Shared.Weather.Models
{
    public class WeatherSystem
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; } = string.Empty;
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}
