using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Testimonials
                .Where(x => x.IsApproved)
                .OrderByDescending(x => x.CreatedDate)
                .ToList();
            return View(values);
        }
    }
}
