using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;
        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Messages.ToList());

        public IActionResult Delete(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
