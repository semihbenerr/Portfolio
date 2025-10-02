using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
