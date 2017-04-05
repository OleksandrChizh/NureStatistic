using Microsoft.AspNetCore.Mvc;

namespace NureStatistic.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(Duration = 300)]
        public PartialViewResult IndexContent()
        {
            return PartialView();
        }
    }
}
