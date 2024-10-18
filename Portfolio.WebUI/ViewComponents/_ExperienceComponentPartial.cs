using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();       
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
