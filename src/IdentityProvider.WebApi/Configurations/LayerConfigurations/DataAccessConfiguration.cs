using IdentityProvider.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace IdentityProvider.WebApi.Configurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            string connection = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connection);
            });
        }
    }
}
