using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using XamQuiz.Resource;

namespace XamQuiz.Model
{
    public class PublicUserScore
    {
        [JsonProperty("publicScores")]
        public  List<PublicUser> PublicUserScores { get; set; }

        public class PublicUser
        {
            [JsonProperty(PropertyName = "userName")]
            public string UserName { get; set; }

            [JsonProperty(PropertyName = "score")]
            public int Score { get; set; }

            [JsonProperty(PropertyName = "country")]
            public string Country { get; set; }

            private string _avatar;
            [JsonIgnore]
            public string PublicAvatar
            {
                get
                {
                    _avatar = Constants.AvatarEndpointSmall + Regex.Replace(UserName ?? "default", @"\s+", "")?.ToLower() +
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
}
