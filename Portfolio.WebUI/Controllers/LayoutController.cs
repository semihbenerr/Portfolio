using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
