using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using NureStatistic.BLL.Interfaces;

namespace NureStatistic.Web.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        [HttpGet]
        public async Task<JsonResult> GetTeacherStatistic(string teacherId, DateTime from, DateTime to)
        {
            SetDefaultInterval(ref from, ref to);

            var result = await _statisticService.GetTeacherStatisticAsync(teacherId, from, to);

            return Json(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetGroupStatistic(string groupId, DateTime from, DateTime to)
        {
            SetDefaultInterval(ref from, ref to);

            var result = await _statisticService.GetGroupStatisticAsync(groupId, from, to);

            return Json(result);
        }

        private void SetDefaultInterval(ref DateTime from, ref DateTime to)
        {
            if (from == default(DateTime) && to == default(DateTime))
            {
                from = DateTime.UtcNow;
                to = from.AddDays(14);
            }
            else if (from != default(DateTime) && to == default(DateTime))
            {
                to = from.AddDays(14);
            }
        }
    }
}