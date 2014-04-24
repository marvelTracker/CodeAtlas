using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ServiceMate.Models;

namespace ServiceMate.Web.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
           
            HttpClient client = new HttpClient();

            UserModel[] model = null;

            var task = client.GetAsync("http://localhost:49220/api/User").ContinueWith(

                (taskWithResponse) =>
                {
                    var response = taskWithResponse.Result;
                    var readTask = response.Content.ReadAsAsync<UserModel[]>();
                    readTask.Wait();
                    model = readTask.Result;
                });

            task.Wait();
           
            return View(model);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Quotes()
        {
            return View();
        }
    }

   
}
