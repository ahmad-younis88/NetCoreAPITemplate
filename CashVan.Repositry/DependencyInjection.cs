using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CashVan.Common.Generic;

namespace CashVan.Repositry
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositry(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext.AppContext>(options =>
                         options.UseSqlServer(
                             configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IDapper, Dapper>();
            return services;
        }
    }
}
