using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLearning.Filters;

namespace MvcLearning.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }

    }
}
