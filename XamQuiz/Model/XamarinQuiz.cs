using System;
using Newtonsoft.Json;

namespace XamQuiz.Model
{
    public class XamarinQuiz
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        [JsonProperty(PropertyName = "firstAnswer")]
        public string Answer1 { get; set; }

        [JsonProperty(PropertyName = "sceondAnswer")]
        public string Answer2 { get; set; }

        [JsonProperty(PropertyName = "thirdAnswer")]
        public string Answer3 { get; set; }

        [JsonProperty(PropertyName = "forthAnswer")]
        public string Answer4 { get; set; }

        [JsonProperty(PropertyName = "correcAnswer")]
        public int CorrectAnswer { get; set; }
    }
}
