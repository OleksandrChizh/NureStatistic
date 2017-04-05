using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class DirectionDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "specialities")]
        public IEnumerable<SpecialityDto> Specialities { get; set; }

        [JsonProperty(PropertyName = "groups")]
        public IEnumerable<GroupDto> Groups { get; set; }
    }
}
