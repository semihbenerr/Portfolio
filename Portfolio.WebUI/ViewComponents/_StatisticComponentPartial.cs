using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
