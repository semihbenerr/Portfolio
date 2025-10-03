using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
