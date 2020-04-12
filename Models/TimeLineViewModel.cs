using KoronaTakipV2.Models.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models
{
    public class TimeLineViewModel
    {
        [JsonProperty("data")]
        public CountryTimeLine[] CountryTimeLines { get; set; }


    }

}
