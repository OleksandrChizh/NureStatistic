using System.Threading.Tasks;

using NureStatistic.BLL.Dto;

namespace NureStatistic.BLL.Interfaces
{
    public interface IStructureService
    {
        Task<UniversityDto> GetTeacherStructure();

        Task<UniversityDto> GetGroupStructure();

        Task<UniversityDto> GetAuditoryStructure();
    }
}