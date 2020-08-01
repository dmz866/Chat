using System.Web.Mvc;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Chat", "Home");
            }

            return RedirectToAction("Login", "Account");
        }
        [Authorize]
        public ActionResult Chat(string email)
        {
            return View();
        }
    }
}