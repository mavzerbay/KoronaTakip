using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using KoronaTakipV2.Models;
using KoronaTakipV2.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace KoronaTakipV2.Controllers
{
    public class LineChartController : Controller
    {
        private readonly ILogger<LineChartController> _logger;
        Database _dataBase = new Database();
        public LineChartController(ILogger<LineChartController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index(string code)
        {
            var table = _dataBase.TableDataTable(@"SELECT *  FROM[dbo].[CountryTimeLineView] where Code = '" + code + "' order by Dates");
            DataRow row = table.Rows[0];
            var title = row[0].ToString();
            CountryTimeLineViewModel model = new CountryTimeLineViewModel
            {
                Title = row[0].ToString(),
                TotalCases = int.Parse(row[5].ToString()),
                TotalRecovered = int.Parse(row[6].ToString()),
                TotalDeaths = int.Parse(row[7].ToString()),
                TotalNewCasesToday = int.Parse(row[8].ToString()),
                TotalNewDeathsToday = int.Parse(row[9].ToString()),
                TotalSeriousCases = int.Parse(row[10].ToString()),
                Code = code
            };
            return View(model);
        }
        public JsonResult CountryDetail(string code)
        {

            try
            {
                var table = _dataBase.TableDataTable("SELECT * FROM CountryTimeLine where CountryCode = '"+code+"' order by dates ");
                List<CountryTimeLine> values = new List<CountryTimeLine>();
                foreach (DataRow row in table.Rows)
                {
                    values.Add(new CountryTimeLine
                    {
                        Cases = int.Parse(row["Cases"].ToString()),
                        Dates = row["Dates"].ToString(),
                        Deaths = int.Parse(row["Deaths"].ToString()),
                        Recovered = int.Parse(row["Recovered"].ToString())
                    });
                }
                return Json(values);




                //var _select = "SELECT * FROM CountryResultView where Code ='"+code+"'";
                //var model = _dataBase.TableDataTable(_select);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}