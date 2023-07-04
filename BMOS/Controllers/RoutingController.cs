using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMOS.Controllers
{
    public class RoutingController : Controller
    {
        // GET: RoutingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoutingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
     
    }
}
