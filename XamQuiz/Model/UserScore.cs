using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using XamQuiz.Resource;

namespace XamQuiz.Model
{
    public class UserScore
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        private string _avatar;
        [JsonIgnore]
        public string Avatar
        {
            get
            {
                _avatar = Constants.AvatarEndpoint + Regex.Replace(UserName ?? "default", @"\s+", "")?.ToLower() +
                 Constants.AvatarEndpointExtesion;
                return _avatar;
            }
            set
            {
                _avatar = value;
            }
        }
    }
}
