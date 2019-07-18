using Microsoft.AspNetCore.Mvc;

namespace CS.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

    }
}
