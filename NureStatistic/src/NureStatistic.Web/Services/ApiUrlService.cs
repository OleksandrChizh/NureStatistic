using NureStatistic.BLL.Interfaces;
using Microsoft.Extensions.Options;

namespace NureStatistic.Web.Services
{
    public class ApiUrlService : IApiUrlsService
    {
        private readonly NureApiUrls _urls;

        public ApiUrlService(IOptions<NureApiUrls> options)
        {
            _urls = options.Value;
        }

        public string GetAuditoriesStructureUrl()
        {
            return _urls.AuditoriesStructureUrl;
        }

        public string GetGroupsStructureUrl()
        {
            return _urls.GroupsStructureUrl;
        }

        public string GetTeachersStructureUrl()
        {
            return _urls.TeachersStructureUrl;
        }

        public string GetTeacherEventsUrl(string teacherId, long from, long to)
        {
            const int TeacherEventType = 2;

            var eventsUrl = GetEventsUrl(TeacherEventType, teacherId, from, to);

            return eventsUrl;
        }

        public string GetGroupEventsUrl(string groupId, long from, long to)
        {
            const int GroupEventType = 1;

            var eventsUrl = GetEventsUrl(GroupEventType, groupId, from, to);

            return eventsUrl;
        }

        private string GetEventsUrl(int eventType, string timeTableId, long from, long to)
        {
            var eventsUrl = $"{_urls.EventsUrl}?"
                   + $"{_urls.TimeTableIdParam}={timeTableId}&"
                   + $"{_urls.EventTypeParam}={eventType}&"
                   + $"{_urls.TimeFromParam}={from}&"
                   + $"{_urls.TimeToParam}={to}";

            return eventsUrl;
        }
    }
}
