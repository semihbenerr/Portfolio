using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}