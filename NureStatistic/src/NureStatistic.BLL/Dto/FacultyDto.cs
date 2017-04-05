using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class FacultyDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "departments")]
        public IEnumerable<DepartmentDto> Departments { get; set; }

        [JsonProperty(PropertyName = "directions")]
        public IEnumerable<DirectionDto> Directions { get; set; }
    }
}
