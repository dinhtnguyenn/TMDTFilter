using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDTFilter.Models;
using WebApplication6.Helpers;

namespace TMDTFilter.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetSearchFilter()
        {
            var listData = db.laptops.ToList();
            SearchParameters objSearch = new SearchParameters();
            objSearch.Company = listData.GroupBy(l => l.Company).Select(l => l.Key).ToList();
            objSearch.CPU = listData.GroupBy(l => l.Cpu).Select(l => l.Key).ToList();
 

            return PartialView(objSearch);
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