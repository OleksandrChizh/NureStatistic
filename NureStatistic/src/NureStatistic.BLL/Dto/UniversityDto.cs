using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class UniversityDto
    {
        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "faculties")]
        public IEnumerable<FacultyDto> Faculties { get; set; }

        [JsonProperty(PropertyName = "buildings")]
        public IEnumerable<BuildingDto> Buildings { get; set; }
    }
}
