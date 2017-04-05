using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class EventTypeDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
