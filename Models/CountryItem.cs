using KoronaTakipV2.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models
{
    public class CountryItem
    {
        [JsonProperty("ourid")]
        public long Ourid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("total_cases")]
        public long TotalCases { get; set; }

        [JsonProperty("total_recovered")]
        public long TotalRecovered { get; set; }

        [JsonProperty("total_unresolved")]
        public long TotalUnresolved { get; set; }

        [JsonProperty("total_deaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("total_new_cases_today")]
        public long TotalNewCasesToday { get; set; }

        [JsonProperty("total_new_deaths_today")]
        public long TotalNewDeathsToday { get; set; }

        [JsonProperty("total_active_cases")]
        public long TotalActiveCases { get; set; }

        [JsonProperty("total_serious_cases")]
        public long TotalSeriousCases { get; set; }
    }
}
