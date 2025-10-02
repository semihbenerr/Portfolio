using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    public class DashboardController : AdminBaseController
    {
        private readonly PortfolioContext _context;

        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.SkillCount = _context.Skills.Count();
            ViewBag.ProjectCount = _context.Portfolios.Count();
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.MessageCount = _context.Messages.Count();
            ViewBag.UnreadMessageCount = _context.Messages.Count(x => !x.IsRead);
            return View();
        }
    }
}