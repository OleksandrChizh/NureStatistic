using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NureStatistic.BLL.Infrastructure.DI
{
    public class DependencyResolverModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            // services.AddTransient<IEmailSender, EmailSender>();
        }
    }
}
