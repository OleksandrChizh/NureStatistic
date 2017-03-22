using Newtonsoft.Json;

namespace NureStatistic.BLL.ApiModels
{
    public class StructureApiModel
    {
        [JsonProperty(PropertyName = "university")]
        public UniversityApiModel University { get; set; }
    }
}
