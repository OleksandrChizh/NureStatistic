using NureStatistic.BLL.Dto;
using NureStatistic.BLL.Interfaces;
using System.Threading.Tasks;
using NureStatistic.BLL.Infrastructure;

namespace NureStatistic.BLL.Services
{
    public class StructureService : IStructureService
    {
        private readonly IApiUrlsService _apiUrlsService;

        public StructureService(IApiUrlsService apiUrlsService)
        {
            _apiUrlsService = apiUrlsService;
        }

        public async Task<UniversityDto> GetAuditoryStructure()
        {
            var url = _apiUrlsService.GetAuditoriesStructureUrl();
            var response = await RequestSender.Get<StructureDto>(url);

            return response.University;
        }

        public async Task<UniversityDto> GetGroupStructure()
        {
            var url = _apiUrlsService.GetGroupsStructureUrl();
            var response = await RequestSender.Get<StructureDto>(url);

            return response.University;
        }

        public async Task<UniversityDto> GetTeacherStructure()
        {
            var url = _apiUrlsService.GetTeachersStructureUrl();
            var response = await RequestSender.Get<StructureDto>(url);

            return response.University;
        }
    }
}
