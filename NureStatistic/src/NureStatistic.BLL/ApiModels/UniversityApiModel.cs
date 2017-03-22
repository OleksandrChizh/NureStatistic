﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace NureStatistic.BLL.ApiModels
{
    public class UniversityApiModel
    {
        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "faculties")]
        public IEnumerable<FacultyApiModel> Faculties { get; set; }
    }
}
