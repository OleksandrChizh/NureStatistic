using System;
using System.Linq;
using System.Threading.Tasks;

using NureStatistic.BLL.Dto;
using NureStatistic.BLL.Infrastructure;
using NureStatistic.BLL.Interfaces;

namespace NureStatistic.BLL.Services
{
    public class StatisticService : IStatisticService
    {
        private const string KievTimeZoneId = "FLE Standard Time";

        private readonly IApiUrlsService _apiUrlsService;

        public StatisticService(IApiUrlsService apiUrlsService)
        {
            _apiUrlsService = apiUrlsService;
        }

        public async Task<EventsStatisticDto> GetTeacherStatisticAsync(string teacherId, DateTime from, DateTime to)
        {
            return await GetStatisticAsync(teacherId, from, to, _apiUrlsService.GetTeacherEventsUrl);
        }

        public async Task<EventsStatisticDto> GetGroupStatisticAsync(string groupId, DateTime from, DateTime to)
        {
            return await GetStatisticAsync(groupId, from, to, _apiUrlsService.GetGroupEventsUrl);
        }

        private async Task<EventsStatisticDto> GetStatisticAsync(
            string targetId,
            DateTime from,
            DateTime to,
            Func<string, long, long, string> urlProvider)
        {
            var result = new EventsStatisticDto();

            from = from.AddDays(-1);
            var fromAsSeconds = ToUnixDateTime(from);
            var toAsSeconds = ToUnixDateTime(to);

            var url = urlProvider(targetId, fromAsSeconds, toAsSeconds);
            var response = await RequestSender.Get<EventResultDto>(url);

            foreach (var item in response.Events)
            {
                var datetime = ToUtcDateTime(item.StartTime);
                var date = datetime.Date;

                var dailyOccupation = result.DailyOccupations.SingleOrDefault(o => o.Date == date);
                if (dailyOccupation == null)
                {
                    dailyOccupation = new DailyOccupationDto { Date = date, EventsCount = 1 };
                    result.DailyOccupations.Add(dailyOccupation);
                }
                else
                {
                    dailyOccupation.EventsCount++;
                }

                var eventType = response.EventTypes.Single(t => t.Id == item.Type).Type;
                var eventTypeCount = result.EventTypeCounts.SingleOrDefault(t => t.Type == eventType);
                if (eventTypeCount == null)
                {
                    eventTypeCount = new EventTypeCountDto { Type = eventType, Count = 1 };
                    result.EventTypeCounts.Add(eventTypeCount);
                }
                else
                {
                    eventTypeCount.Count++;
                }
            }

            return result;
        }

        private DateTime ToUtcDateTime(long unixDateAsSeconds)
        {
            var unixStartDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            var sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById(KievTimeZoneId);
            var destinationTimeZone = TimeZoneInfo.Utc;

            var date = unixStartDate.AddSeconds(unixDateAsSeconds);
            var utcDate = TimeZoneInfo.ConvertTime(date, sourceTimeZone, destinationTimeZone);

            return utcDate;
        }

        private long ToUnixDateTime(DateTime utcDate)
        {
            var unixStartDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            var sourceTimeZone = TimeZoneInfo.Utc;
            var destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(KievTimeZoneId);

            var date = TimeZoneInfo.ConvertTime(utcDate, sourceTimeZone, destinationTimeZone);
            var dateAsSeconds = (long)(date - unixStartDate).TotalSeconds;

            return dateAsSeconds;
        }
    }
}
