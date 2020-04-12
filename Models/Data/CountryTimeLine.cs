using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.Data
{
    public class CountryTimeLine
    {
        [JsonProperty("countrycode")]
        public string CountryCode { get; set; }

        [JsonProperty("date")]
        public string Dates { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

    }
}
