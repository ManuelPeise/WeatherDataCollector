namespace Shared.Database.Entities
{
    public class City: EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int TimeZoneOffset { get; set; }
    }
}
