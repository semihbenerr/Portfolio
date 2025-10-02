using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.Areas.Admin.Models;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var skills = context.Skills.ToList();
            var dashboardViewModel = new DashboardViewModel
            {
                Skills = skills
            };
            return View(dashboardViewModel);

        }
    }
}
