using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using KoronaTakipV2.Models;
using KoronaTakipV2.Models.AdminObjects;
using KoronaTakipV2.Models.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using RestSharp;

namespace KoronaTakipV2.Controllers
{
    
    public class AdminController : Controller
    {
        Database _dataBase = new Database();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult GenelAyarlar(string updateTime = "", string actionName = "")
        {
            if (updateTime == "" && actionName == "")
            {
                return FillActions();
            }
            else
            {
                UpdateTime model = new UpdateTime
                {
                    ActionName = actionName,
                    Updated = updateTime
                };
                var _update = $@"UPDATE [dbo].[UpdateTimes]
                                       SET [UpdateTime] = '{model.Updated}'
                                     WHERE [ActionName]= '{model.ActionName}'";
                _dataBase.Komut(_update);

                return FillActions();
            }

        }
        [Authorize]
        private IActionResult FillActions()
        {
            var _select = "select * from UpdateTimes";
            var dt = _dataBase.TableDataTable(_select);
            List<UpdateTime> model = new List<UpdateTime>();
            foreach (DataRow row in dt.Rows)
            {
                model.Add(new UpdateTime
                {
                    ActionName = row["ActionName"].ToString(),
                    Updated = row["UpdateTime"].ToString()
                });
            }
            return View(model);
        }
        [Authorize]
        public IActionResult AddTotal()
        {
            try
            {
                var apiUrl = "https://thevirustracker.com/free-api?global=stats";
                Uri url = new Uri(apiUrl);
                var json = new WebClient().DownloadString(apiUrl);
                var resultList = JsonConvert.DeserializeObject<TotalModel>(json);
                var _update = $@"UPDATE [dbo].[ResultsTest]
                                       SET [TotalCases] = '{resultList.Results[0].TotalCases}'
                                          ,[TotalRecovered] = '{resultList.Results[0].TotalRecovered}'
                                          ,[TotalUnresolved] = '{resultList.Results[0].TotalUnresolved}'
                                          ,[TotalDeaths] = '{resultList.Results[0].TotalDeaths}'
                                          ,[TotalNewCasesToday] = '{resultList.Results[0].TotalNewCasesToday}'
                                          ,[TotalNewDeathsToday] = '{resultList.Results[0].TotalNewDeathsToday}'
                                          ,[TotalActiveCases] = '{resultList.Results[0].TotalActiveCases}'
                                          ,[TotalSeriousCases] = '{resultList.Results[0].TotalSeriousCases}'
                                          ,[TotalAffectedCountries] = '{resultList.Results[0].TotalAffectedCountries}'
                                     WHERE ResultId='0'";
                ;
                if (_dataBase.Komut(_update))
                {
                    TempData["sonuc1"] = "Bilgiler Güncellendi";
                    return RedirectToAction("GenelAyarlar", new { updateTime = DateTime.Now.ToString(), actionName = RouteData.Values["action"].ToString() });
                }
                else
                {
                    TempData["sonuc0"] = "Bilgiler Güncellenemedi";
                    return RedirectToAction("GenelAyarlar");
                }

            }
            catch (Exception ex)
            {
                ViewBag.exHata = ex.Message;
                return View();
            }
        }
        [Authorize]
        public IActionResult AddTimeLine()
        {
            try
            {
                var client = new RestClient("https://thevirustracker.com/timeline/map-data.json");
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");
                var response = client.Execute(request);
                var output = JsonConvert.DeserializeObject<TimeLineViewModel>(response.Content);
                int id = 1;
                foreach (var item in output.CountryTimeLines)
                {
                    var idMaxSql = "SELECT  max([TimeLineId]) FROM[KoronaTakip].[dbo].[CountryTimeLine]";
                    var idMax = _dataBase.TableDataTable(idMaxSql);
                    if (id > int.Parse(idMax.Rows[0]["Column1"].ToString()))
                    {
                        var _insert = $@"INSERT INTO [dbo].[CountryTimeLine]
                                    ([CountryCode]
                                   ,[Dates]
                                   ,[Cases]
                                   ,[Deaths]
                                   ,[Recovered])
                             VALUES
                                   ('{item.CountryCode}',
                                    '{item.Dates}',
                                    '{item.Cases}' ,
                                    '{item.Deaths}',
                                    '{item.Recovered}')";
                        
                        _dataBase.Komut(_insert);
                    }
                    id++;

                }
                if (output.CountryTimeLines.Length > 0)
                {
                    TempData["sonuc1"] = "Bilgiler Güncellendi";
                    return RedirectToAction("GenelAyarlar", new { updateTime = DateTime.Now.ToString(), actionName = RouteData.Values["action"].ToString() });
                }
                else
                {
                    TempData["sonuc0"] = "Bilgiler Güncellenemedi";
                    return RedirectToAction("GenelAyarlar");
                }


            }
            catch (Exception ex)
            {
                TempData["exHata"] = ex.Message;
                return RedirectToAction("GenelAyarlar");
            }
        }
        [Authorize]
        public IActionResult AddToDb()
        {
            try
            {
                var client = new RestClient("https://api.thevirustracker.com/free-api?countryTotals=ALL");
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");
                var response = client.Execute(request);
                var output = JsonConvert.DeserializeObject<DataC>(response.Content);

                foreach (var item in output.Countryitems[0])
                {
                    if (item.Key != "stat")
                    {
                        var value = item.Value.ToString();
                        var model = JsonConvert.DeserializeObject<CountryItem>(value);

                        var _insertInfo = $@"UPDATE [dbo].[Infos] SET
                                       [Ourid]='{model.Ourid}'
                                       ,[Title]='{model.Title}'
                                       ,[Code]='{model.Code}'
                                 WHERE InfoId = '{item.Key}'";
                        _dataBase.Komut(_insertInfo);
                        var _insertResult = $@"UPDATE [dbo].[ResultsTest] SET
                                            [TotalCases]='{model.TotalCases}'
                                           ,[TotalRecovered]='{model.TotalRecovered}'
                                           ,[TotalUnresolved]='{model.TotalUnresolved}'
                                           ,[TotalDeaths]='{model.TotalDeaths}'
                                           ,[TotalNewCasesToday]='{model.TotalNewCasesToday}'
                                           ,[TotalNewDeathsToday]='{model.TotalNewDeathsToday}'
                                           ,[TotalActiveCases]='{model.TotalActiveCases}'
                                           ,[TotalSeriousCases]='{model.TotalSeriousCases}'
                                     WHERE ResultId = '{item.Key}'";
                        _dataBase.Komut(_insertResult);

                    }
                }
                if (output.Countryitems[0].Count > 0)
                {
                    TempData["sonuc1"] = "Bilgiler Güncellendi";
                    return RedirectToAction("GenelAyarlar", new { updateTime = DateTime.Now.ToString(), actionName = RouteData.Values["action"].ToString() });
                }
                else
                {
                    TempData["sonuc0"] = "Bilgiler Güncellenemedi";
                    return RedirectToAction("GenelAyarlar");
                }


            }
            catch (Exception ex)
            {
                TempData["exHata"] = ex.Message;
                return RedirectToAction("GenelAyarlar");
            }
        }
    }
}