using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Catalog.Core.Data;
using Module.Catalog.InfraStructure.Data;
using Shared.InfraStructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Catalog.InfraStructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<CatalogDbContext>(config)
                .AddScoped<ICatalogDbContext>(provider => provider.GetService<CatalogDbContext>());
            return services;
        }
    }
}
