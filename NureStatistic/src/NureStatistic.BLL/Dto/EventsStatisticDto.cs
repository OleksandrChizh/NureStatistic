using System.Collections.Generic;

namespace NureStatistic.BLL.Dto
{
    public class EventsStatisticDto
    {
        public ICollection<DailyOccupationDto> DailyOccupations { get; set; } = new List<DailyOccupationDto>();

        public ICollection<EventTypeCountDto> EventTypeCounts { get; set; } = new List<EventTypeCountDto>();
    }
}
