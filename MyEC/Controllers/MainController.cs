using MyEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEC.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Top()
        {
            var model = new Top();

            return View(model);
        }

        public ActionResult ProductDetail(string ProductId)
        {
            var model = new ProductDetail();

            return View(model);
        }
    }
}