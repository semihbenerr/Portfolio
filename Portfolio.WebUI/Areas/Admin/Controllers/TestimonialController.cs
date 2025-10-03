using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.Areas.Admin.Models;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly PortfolioContext _context;
        public TestimonialController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Testimonials.ToList());

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Testimonial testimonial)
        {
            if (ModelState.IsValid)
            {
                _context.Testimonials.Add(testimonial);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonial);
        }

        public IActionResult Edit(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            return testimonial == null ? NotFound() : View(testimonial);
        }

        [HttpPost]
        public IActionResult Edit(Testimonial testimonial)
        {
            if (ModelState.IsValid)
            {
                _context.Testimonials.Update(testimonial);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonial);
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