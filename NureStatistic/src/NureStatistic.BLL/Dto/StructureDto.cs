using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class StructureDto
    {
        [JsonProperty(PropertyName = "university")]
        public UniversityDto University { get; set; }
    }
}
