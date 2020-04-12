using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KoronaTakipV2.Models;
using KoronaTakipV2.Models.Data;
using RestSharp.Serialization.Json;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using System.Data;

namespace KoronaTakipV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Database _dataBase = new Database();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Index()
        {
            try
            {

                var _select = @"SELECT [ResultId]
                              ,[TotalCases]
                              ,[TotalRecovered]
                              ,[TotalUnresolved]
                              ,[TotalDeaths]
                              ,[TotalNewCasesToday]
                              ,[TotalNewDeathsToday]
                              ,[TotalActiveCases]
                              ,[TotalSeriousCases]
                              ,[TotalAffectedCountries]
                              ,[TotalDangerRank]
                              ,[InfoId]
                          FROM[dbo].[ResultsTest]
                          where ResultId = 0";
                var data = _dataBase.TableDataTable(_select);
                Results result = new Results
                {
                    TotalCases = int.Parse(data.Rows[0]["TotalCases"].ToString()),
                    TotalRecovered = int.Parse(data.Rows[0]["TotalRecovered"].ToString()),
                    TotalUnresolved = int.Parse(data.Rows[0]["TotalUnresolved"].ToString()),
                    TotalDeaths = int.Parse(data.Rows[0]["TotalDeaths"].ToString()),
                    TotalNewCasesToday = int.Parse(data.Rows[0]["TotalNewCasesToday"].ToString()),
                    TotalNewDeathsToday = int.Parse(data.Rows[0]["TotalNewDeathsToday"].ToString()),
                    TotalActiveCases = int.Parse(data.Rows[0]["TotalActiveCases"].ToString()),
                    TotalSeriousCases = int.Parse(data.Rows[0]["TotalSeriousCases"].ToString()),
                    TotalAffectedCountries = int.Parse(data.Rows[0]["TotalAffectedCountries"].ToString())
                };
                return View(result);

            }
            catch (Exception ex)
            {
                ViewBag.exHata = ex.Message;
                return View();
            }
        }


        public IActionResult ShowAll()
        {
            try
            {
                var _select = @"SELECT *
                      FROM [dbo].[CountryResultView] order by TotalDeaths desc";
                var model = _dataBase.TableDataTable(_select);


                return View(model);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
