using CarMate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarMate.Controllers
{
    public class HomeController : Controller
    {
        private ServiceMateContext db = new ServiceMateContext();
        public ActionResult Index()
        {
            var departconsumer = db.Consumer.ToList(); 
            
            return View();
        }
    }
}
