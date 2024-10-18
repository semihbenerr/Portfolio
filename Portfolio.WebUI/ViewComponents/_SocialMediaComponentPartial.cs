using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {

            var values = portfolioContext.SocialMedias.ToList();
            return View(values);
        }
    }
}
