using AgriAnalyticoServer.Contracts;
using AgriAnalyticoServer.Models;
using AgriAnalyticoServer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgriAnalyticoServer.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureDatabaseContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:sqlserver"];
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        }
    }
}