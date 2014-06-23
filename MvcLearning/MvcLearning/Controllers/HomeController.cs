using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLearning.Models;

namespace MvcLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var CurrController = RouteData.Values["controller"];
            var CurrAction = RouteData.Values["action"];
            var CurrId = RouteData.Values["id"];

            ViewBag.Message = String.Format("{0}::{1} {2}", CurrController, CurrAction, CurrId);
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModels();
            model.Name = "Le Binh";
            model.Location = "Ho Chi Minh, VN";
            
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
