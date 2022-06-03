using Microsoft.AspNetCore.Mvc;

namespace TelephoneDirectory.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
