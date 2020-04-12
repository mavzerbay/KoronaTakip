using KoronaTakipV2.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models
{
    public class TotalModel
    {
        [JsonProperty("results")]
        public Results[] Results { get; set; }
    }
}
