using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class AuditoryTypeDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }
    }
}
