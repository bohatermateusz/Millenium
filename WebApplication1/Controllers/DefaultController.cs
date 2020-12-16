using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {

        private readonly DefaultController _context;

        public DefaultController(DefaultController context)
        {
            _context = context;
        }
        // GET: Default
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Summary()
        {
            return View();
        }
    }
}