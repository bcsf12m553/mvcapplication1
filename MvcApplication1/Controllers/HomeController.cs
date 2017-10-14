using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

using System.Data.Entity;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        soundsystemsEntities mdi = new soundsystemsEntities();


        public ActionResult Index()
        {


            return View(mdi.Products.ToList());
        }

    }
}
