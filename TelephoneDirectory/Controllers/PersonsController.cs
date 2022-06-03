using Microsoft.AspNetCore.Mvc;

namespace TelephoneDirectory.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
