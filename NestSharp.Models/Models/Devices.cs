using Newtonsoft.Json;
using System.Collections.Generic;

namespace NestSharp.Models
{
    public class Devices
    {
        [JsonProperty ("thermostats")]
        public Dictionary<string, Thermostat> Thermostats { get;set; }

        [JsonProperty ("smoke_co_alarms")]
        public Dictionary<string, SmokeCoAlarm> SmokeCoAlarms { get;set; }
    }
}
