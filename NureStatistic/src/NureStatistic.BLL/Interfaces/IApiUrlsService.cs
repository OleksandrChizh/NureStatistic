namespace NureStatistic.BLL.Interfaces
{
    public interface IApiUrlsService
    {
        string GetTeachersStructureUrl();

        string GetGroupsStructureUrl();

        string GetAuditoriesStructureUrl();

        string GetTeacherEventsUrl(string teacherId, long from, long to);

        string GetGroupEventsUrl(string groupId, long from, long to);
    }
}
