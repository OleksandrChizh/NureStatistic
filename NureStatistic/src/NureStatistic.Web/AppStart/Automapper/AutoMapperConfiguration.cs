using AutoMapper;
using NureStatistic.BLL.Infrastructure.Automapper;

namespace NureStatistic.Web.AppStart.Automapper
{
    public class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoToViewModelProfile>();
                cfg.AddProfile<ViewModelToDtoProfile>();

                ServiceAutoMapperConfiguration.Initialize(cfg);
            });

            return mapperConfiguration;
        }
    }
}
