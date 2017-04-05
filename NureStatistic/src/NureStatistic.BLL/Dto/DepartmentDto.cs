using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class DepartmentDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "teachers")]
        public IEnumerable<TeacherDto> Teachers { get; set; }
    }
}
