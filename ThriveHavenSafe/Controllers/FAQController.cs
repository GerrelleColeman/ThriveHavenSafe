using Microsoft.AspNetCore.Mvc;

namespace ThriveHavenSafe.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
     
}
