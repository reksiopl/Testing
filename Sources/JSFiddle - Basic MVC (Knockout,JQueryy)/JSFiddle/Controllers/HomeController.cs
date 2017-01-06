using System.Web.Mvc;

namespace JSFiddle.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FirstAjax()
        {
            var redirectUrl = Url.Action("Result");
            return Json(redirectUrl);
        }

        public ActionResult Result()
        {
            return View("Result");
        }

    }
}
