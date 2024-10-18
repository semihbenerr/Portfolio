using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
