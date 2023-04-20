using Microsoft.AspNetCore.Mvc;

namespace practicaMVC.Controllers
{
    public class equipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
