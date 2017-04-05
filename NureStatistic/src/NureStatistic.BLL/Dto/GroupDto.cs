using Newtonsoft.Json;

namespace NureStatistic.BLL.Dto
{
    public class GroupDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
