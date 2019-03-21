using System;
using System.Diagnostics;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XamQuiz.Helpers
{
    public static class JsonHelper
    {
        public static string ToJson<T>(T value)
        {
            try
            {
                return JsonConvert.SerializeObject(value, JsonSettings);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failing serializing object: {nameof(T)} -- {ex.Message} ");
                return string.Empty;
            }
        }

        public static T FromJson<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, JsonSettings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failing deserializing object: {nameof(T)} -- {ex.Message} ");
                return default(T);
            }
        }

        public static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
