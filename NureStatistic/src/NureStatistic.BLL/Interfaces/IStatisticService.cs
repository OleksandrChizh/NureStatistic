using System;
using System.Threading.Tasks;

using NureStatistic.BLL.Dto;

namespace NureStatistic.BLL.Interfaces
{
    public interface IStatisticService
    {
        Task<EventsStatisticDto> GetTeacherStatisticAsync(string teacherId, DateTime from, DateTime to);

        Task<EventsStatisticDto> GetGroupStatisticAsync(string groupId, DateTime from, DateTime to);
    }
}
