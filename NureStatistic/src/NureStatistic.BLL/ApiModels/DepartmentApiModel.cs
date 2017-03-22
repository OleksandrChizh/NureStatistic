﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.ApiModels
{
    public class DepartmentApiModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "teachers")]
        public IEnumerable<TeacherApiModel> Teachers { get; set; }
    }
}