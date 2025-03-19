using Microsoft.AspNetCore.Mvc;

namespace projeto2B.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
