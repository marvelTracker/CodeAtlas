using System.Linq;
using System.Web.Mvc;
using ServiceMate.Repository;

namespace ServiceMate.API.Controllers
{
    public class HomeController : Controller
    {
        private ServiceMateContext db = new ServiceMateContext();
        public ActionResult Index()
        {
           // var departconsumer = db.Consumer.ToList(); 
            
            return View();
        }
    }
}
