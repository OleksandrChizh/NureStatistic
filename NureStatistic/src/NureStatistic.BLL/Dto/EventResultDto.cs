using System.Collections.Generic;

using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class EventResultDto
    {
        [JsonProperty(PropertyName = "time-zone")]
        public string TimeZone { get; set; }

        [JsonProperty(PropertyName = "events")]
        public IEnumerable<EventDto> Events { get; set; }

        [JsonProperty(PropertyName = "types")]
        public IEnumerable<EventTypeDto> EventTypes { get; set; }
    }
}
