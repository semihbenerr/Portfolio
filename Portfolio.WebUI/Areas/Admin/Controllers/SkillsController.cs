using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.Areas.Admin.Models;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
    {
        private readonly PortfolioContext _context;
        public SkillsController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Skills.ToList());

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Add(skill);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skill);
        }

        public IActionResult Edit(int id)
        {
            var skill = _context.Skills.Find(id);
            return skill == null ? NotFound() : View(skill);
        }

        [HttpPost]
        public IActionResult Edit(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Update(skill);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skill);
        }

        public IActionResult Delete(int id)
        {
            var skill = _context.Skills.Find(id);
            if (skill != null)
            {
                _context.Skills.Remove(skill);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}