using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models
{
    public class DataC
    {
        [JsonProperty("sitedata")]
        public Sitedatum[] Sitedata { get; set; }

        [JsonProperty("countryitems")]
        public Dictionary<string, object>[] Countryitems { get; set; }
    }



    public class Sitedatum
    {
        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public class Info
    {
        [JsonProperty("source")]
        public Uri Source { get; set; }
    }
}
