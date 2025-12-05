using Microsoft.AspNetCore.Mvc;

namespace boat_haraj.Controllers
{
    public class AccountContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
