using Microsoft.AspNetCore.Mvc;

namespace ThriveHavenSafe.Controllers
{
    public class Business : Controller
    {
        public IActionResult BusinessPage()
        {
            return View();
        }
    }
}
