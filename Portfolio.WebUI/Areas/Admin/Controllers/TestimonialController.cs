using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    public class TestimonialController : AdminBaseController
    {
        private readonly PortfolioContext _context;

        public TestimonialController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var testimonials = _context.Testimonials
                .OrderByDescending(t => t.CreatedDate)
                .ToList();
            return View(testimonials);
        }

        public IActionResult ToggleApproval(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            if (testimonial != null)
            {
                testimonial.IsApproved = !testimonial.IsApproved;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            if (testimonial != null)
            {
                _context.Testimonials.Remove(testimonial);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}