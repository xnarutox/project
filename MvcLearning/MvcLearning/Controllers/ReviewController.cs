using MvcLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearning.Controllers
{
    public class ReviewController : Controller
    {
        //[ChildActionOnly]
        //public ActionResult BestReview()
        //{ 
        //    var review = from r in _reviews
        //                 orderby r.Rate descending
        //                 select r;
        //    return PartialView("_Review", review.First());
        //}

        //
        // GET: /Review/

        //public ActionResult Index()
        //{
        //    var model = from r in _reviews
        //                orderby r.Country
        //                select r;
        //    return View(model);
        //}

        //
        // GET: /Review/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Review/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Review/Edit/5

        //public ActionResult Edit(int id)
        //{
        //    var review = _reviews.Single(r => r.Id == id);
        //    return View(review);
        //}

        //
        // POST: /Review/Edit/5

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    var review = _reviews.Single(r => r.Id == id);
        //    if (TryUpdateModel(review))
        //    {
        //        return RedirectToAction("Index");            
        //    }
        //    return View(review);
        //}

        //
        // GET: /Review/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Review/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //static List<RestaurantReviewModels> _reviews = new List<RestaurantReviewModels>
        //{
        //    new RestaurantReviewModels
        //    {
        //        Id = 1,
        //        Name = "Pizza Hut",
        //        City = "HCM",
        //        Country = "VN",
        //        Rate = 7
        //    },
        //    new RestaurantReviewModels
        //    {
        //        Id = 2,
        //        Name = "TiTi",
        //        City = "HANOI",
        //        Country = "VN",
        //        Rate = 8
        //    },
        //    new RestaurantReviewModels
        //    {
        //        Id = 3,
        //        Name = "NYDC",
        //        City = "LA",
        //        Country = "USA",
        //        Rate = 4
        //    }
        //};
    }
}
