using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class AuditoryDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "floor")]
        public int? Floor { get; set; }

        [JsonProperty(PropertyName = "is_have_power")]
        public int? IsHavePower { get; set; }

        [JsonProperty(PropertyName = "auditory_types")]
        public IEnumerable<AuditoryTypeDto> AuditoryTypes { get; set; }
    }
}
