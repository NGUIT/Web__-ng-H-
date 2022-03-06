using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_DongHo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult trangchu()
        {

            return View();
        }
        public ActionResult donghonam()
        {

            return View();
        }
        public ActionResult donghonu()
        {

            return View();
        }
        public ActionResult dangky()
        {

            return View();
        }
        public ActionResult LienHe()
        {
       
            return View();
        }
    }
}