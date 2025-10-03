using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly PortfolioContext _context;
        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new
            {
                SkillCount = _context.Skills.Count(),
                ExperienceCount = _context.Experiences.Count(),
                MessageCount = _context.Messages.Count(),
                TestimonialCount = _context.Testimonials.Count()
            };
            return View(model);
        }
    }
}