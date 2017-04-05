using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NureStatistic.BLL.Interfaces;
using NureStatistic.BLL.Services;

namespace NureStatistic.BLL.Infrastructure.DI
{
    public class DependencyResolverModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IStructureService, StructureService>();
            services.AddTransient<IStatisticService, StatisticService>();
        }
    }
}
