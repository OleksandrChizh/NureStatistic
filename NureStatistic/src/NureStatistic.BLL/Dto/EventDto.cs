using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class EventDto
    {
        [JsonProperty(PropertyName = "start_time")]
        public long StartTime { get; set; }

        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
    }
}