using System;
using Newtonsoft.Json;

namespace XamQuiz.Model
{
    public partial class Countries
    {
        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }
}