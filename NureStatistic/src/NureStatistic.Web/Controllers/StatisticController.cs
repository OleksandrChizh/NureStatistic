using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NureStatistic.BLL.ApiModels;
using NureStatistic.BLL.Infrastructure;

namespace NureStatistic.Web.Controllers
{
    public class StatisticController : Controller
    {
        private readonly NureApiUrls _urls;

        public StatisticController(IOptions<NureApiUrls> urls)
        {
            _urls = urls.Value;
        }

        public async Task<ViewResult> Index()
        {
            var model = await RequestSender.Get<StructureApiModel>(_urls.TeachersStructureUrl);

            return View(model);
        }

        public ViewResult About()
        {
            return View();
        }
    }
}
