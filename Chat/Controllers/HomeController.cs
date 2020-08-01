using System.Web.Mvc;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Chat(string email)
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}