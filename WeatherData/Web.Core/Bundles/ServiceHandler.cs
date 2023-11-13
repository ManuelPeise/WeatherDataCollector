using Microsoft.EntityFrameworkCore;


namespace Web.Core.Bundles
{
    public static class ServiceHandler
    {
        public static void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<Data.Database.AppContext>(opt =>
            {
                var connectionString = builder.Configuration.GetConnectionString("AppContext");

                opt.UseMySQL(connectionString);
            });
        }
    }
}
