using Microsoft.EntityFrameworkCore;
using Shared.Database.Entities;

namespace Data.Database
{
    public class AppContext: DbContext
    {
        public DbSet<City> CityTable { get; set; }
        public DbSet<WeatherData> WeatherDataTable { get; set; }
        
        public AppContext(DbContextOptions opt): base(opt) { }
   
    }
}