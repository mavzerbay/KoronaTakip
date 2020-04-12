using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.Data
{
    public class Infos
    {
        public int InfoId { get; set; }
        [JsonProperty("ourid")]
        public long Ourid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
