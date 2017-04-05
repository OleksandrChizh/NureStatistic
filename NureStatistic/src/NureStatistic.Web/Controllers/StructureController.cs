using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NureStatistic.BLL.Interfaces;
using NureStatistic.Web.Attributes;

namespace NureStatistic.Web.Controllers
{
    [AsyncRequest]
    [ResponseCache(Duration = 300)]
    public class StructureController : Controller
    {
        private readonly IStructureService _structureService;

        public StructureController(IStructureService structureService)
        {
            _structureService = structureService;
        }

        [HttpGet]
        public async Task<PartialViewResult> Teacher()
        {
            var university = await _structureService.GetTeacherStructure();

            return PartialView(university);
        }

        [HttpGet]
        public async Task<PartialViewResult> Group()
        {
            var university = await _structureService.GetGroupStructure();

            return PartialView(university);
        }

        [HttpGet]
        public async Task<PartialViewResult> Auditory()
        {
            var university = await _structureService.GetAuditoryStructure();

            return PartialView(university);
        }
    }
}
