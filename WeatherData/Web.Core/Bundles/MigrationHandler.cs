using Microsoft.EntityFrameworkCore;

namespace Web.Core.Bundles
{
    public static class MigrationHandler
    {
        public static void Migrate(WebApplication application)
        {
            //using (var serviceScope = application.Services.CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetService<Data.Database.AppContext>();

            //    if (context.Database.GetPendingMigrations().Any())
            //    {
            //        context.Database.Migrate();
            //    }
            //}
        }
    }
}
