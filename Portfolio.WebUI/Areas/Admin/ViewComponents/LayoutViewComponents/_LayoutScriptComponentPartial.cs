using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.WebUI.Areas.Admin.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
