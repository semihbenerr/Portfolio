using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.Areas.Admin.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
