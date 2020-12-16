using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        protected void CheckBox_Click(object sender, EventArgs e)
        {


            var dil = "en-US";
            //var ci = new CultureInfo(dil); //TO_DO Route culture 
            //Thread.CurrentThread.CurrentUICulture = ci;
            //Thread.CurrentThread.CurrentCulture = ci;
            //Session["culture"] = ci;

            //Sets the cookie that is to be used by Global.asax
            HttpCookie cookie = new HttpCookie("CultureInfo");
            cookie.Value = dil;
            Response.Cookies.Add(cookie);

            //Set the culture and reload the page for immediate effect. 
            //Future effects are handled by Global.asax
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo(dil);
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo(dil);
            Server.Transfer(Request.Path);

        }
    }
}