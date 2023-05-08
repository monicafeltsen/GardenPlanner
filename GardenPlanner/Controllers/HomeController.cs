using Microsoft.AspNetCore.Mvc;

namespace GardenPlanner.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
