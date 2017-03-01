using Microsoft.AspNetCore.Mvc;

namespace NureStatistic.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
