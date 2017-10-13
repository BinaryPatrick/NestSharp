using Newtonsoft.Json;

namespace NestSharp.Models
{
    public class MetaData
    {
        [JsonProperty ("access_token")]
        public string AccessToken { get;set; }

        [JsonProperty ("client_version")]
        public double ClientVersion { get;set; }
    }
}
