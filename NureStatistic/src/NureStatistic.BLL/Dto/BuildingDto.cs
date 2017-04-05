using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class BuildingDto
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "auditories")]
        public IEnumerable<AuditoryDto> Auditories { get; set; }
    }
}
