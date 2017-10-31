using DemoMvcApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DemoMvcApplication.Controllers
{
    public class BikesModel
    {
        public List<string> bikes { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://trekhiringassignments.blob.core.windows.net/interview/bikes.json");
            }

            List<BikesModel> bikesList = JsonConvert.DeserializeObject<List<BikesModel>>(json);

            //var results = bikesList.GroupBy(a => a.bikes).Select(a=>a);
            var resutls1 = bikesList.SelectMany(x => x.bikes).GroupBy(z => z).Select(g => new { g.Key, count = g.Count() }).ToList();

            var resutls2 = bikesList.SelectMany(x => x.bikes)
                .GroupBy(z => z).Select(g => new { g.Key, count = g.Count() })
                .OrderByDescending(a => a.count)
                .Take(20).ToList();
            
            return View(bikesList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}