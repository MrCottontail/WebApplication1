using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class c1Controller : Controller
    {
        // 
        // GET: /c1/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /c1/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}