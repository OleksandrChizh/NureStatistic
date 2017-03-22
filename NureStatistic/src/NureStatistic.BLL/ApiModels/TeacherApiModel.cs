using Newtonsoft.Json;

namespace NureStatistic.BLL.ApiModels
{
    public class TeacherApiModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }
    }
}
