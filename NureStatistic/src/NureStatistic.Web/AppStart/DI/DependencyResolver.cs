using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NureStatistic.BLL.Infrastructure.DI;
using NureStatistic.BLL.Interfaces;
using NureStatistic.Web.Services;

namespace NureStatistic.Web.AppStart.DI
{
    public class DependencyResolver
    {
        public static void Resolve(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IApiUrlsService, ApiUrlService>();

            DependencyResolverModule.Configure(services, configuration);
        }
    }
}
