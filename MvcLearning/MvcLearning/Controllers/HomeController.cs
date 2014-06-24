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
        MVCLearningDb _Db = new MVCLearningDb();

        public ActionResult Index()
        {
            var restaurants = _Db.Restaurants.ToList();
            return View(restaurants);
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

        protected override void Dispose(bool disposing)
        {
            if (_Db != null)
                _Db.Dispose();
            base.Dispose(disposing);
        }
    }
}
