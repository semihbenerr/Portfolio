using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.WebUI.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
