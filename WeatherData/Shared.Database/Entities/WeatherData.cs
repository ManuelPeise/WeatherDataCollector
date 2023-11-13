using System.ComponentModel.DataAnnotations.Schema;


namespace Shared.Database.Entities
{
    public class WeatherData: EntityBase
    {
        public DateTime TimeStamp { get; set; }
        [ForeignKey("Id")]
        public City City { get; set; } = new City();
        public string Icon { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Temp { get; set; }
        public float Feels { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
        public int Pressure { get; set; }
        public float Humidity { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}
