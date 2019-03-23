using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
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

        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);
        public static async Task<string> LocalJson(string filePath) 
        {
            if (string.IsNullOrEmpty(filePath))
                return null;
            string json = null;
            //Asynchronously wait to enter the Semaphore. If no-one has been granted access to the Semaphore, code execution will proceed, otherwise this thread waits here until the semaphore is released 
            await semaphoreSlim.WaitAsync();
            try
            {
                var assembly = typeof(JsonHelper).GetTypeInfo().Assembly;
                using (var stream = assembly.GetManifestResourceStream(filePath)) 
                {
                    using (var reader = new StreamReader(stream))
                    {
                         json = await reader.ReadToEndAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                //When the task is ready, release the semaphore. It is vital to ALWAYS release the semaphore when we are ready, or else we will end up with a Semaphore that is forever locked.
                //This is why it is important to do the Release within a try...finally clause; program execution may crash or take a different path, this way you are guaranteed execution
                semaphoreSlim.Release();
            };
            return json;
        }
    }
}
