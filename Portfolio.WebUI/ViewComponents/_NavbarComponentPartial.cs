using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
