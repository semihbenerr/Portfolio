using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly PortfolioContext _context;

        public TestimonialController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var approvedTestimonials = _context.Testimonials
                .Where(t => t.IsApproved)
                .OrderByDescending(t => t.CreatedDate)
                .ToList();
            return View(approvedTestimonials);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View(testimonial);
            }

            testimonial.CreatedDate = DateTime.Now;
            testimonial.IsApproved = false;
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();

            TempData["Message"] = "Thank you for your testimonial! It will be reviewed and published soon.";
            return RedirectToAction("Index");
        }
    }
}