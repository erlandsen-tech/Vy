using System.Web.Mvc;

namespace VyBillettBestilling.Controllers
{
    public class RegistreringController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registrer()
        {
            return View();
        }
    }
}