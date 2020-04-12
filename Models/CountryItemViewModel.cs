using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoronaTakipV2.Models.Data;
using Newtonsoft.Json;

namespace KoronaTakipV2.Models
{
    public class CountryItemViewModel
    {
        public string Title { get; set; }
        public long TotalCases { get; set; }
        public long TotalDeaths { get; set; }
        public long TotalRecovered { get; set; }
        public long TotalNewCasesToday { get; set; }
        public long TotalNewDeathsToday { get; set; }
        public long TotalActiveCases { get; set; }
        public long TotalSeriousCases { get; set; }
        public int TotalDangerRank { get; set; }
    }
}
