using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NureStatistic.BLL.Infrastructure.DI;

namespace NureStatistic.Web.AppStart.DI
{
    public class DependencyResolver
    {
        public static void Resolve(IServiceCollection services, IConfiguration configuration)
        {
            // services.AddTransient<INotificationService, NotificationService>();

            DependencyResolverModule.Configure(services, configuration);
        }
    }
}
