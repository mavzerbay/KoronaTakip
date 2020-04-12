using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models
{
    public class CountryTimeLineViewModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Dates { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int TotalCases { get; set; }
        public int TotalRecovered { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalNewCasesToday { get; set; }
        public int TotalNewDeathsToday { get; set; }
        public int TotalSeriousCases { get; set; }
    }
}
