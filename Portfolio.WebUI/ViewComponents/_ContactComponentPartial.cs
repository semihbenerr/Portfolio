using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        PortfolioContext context = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.address = context.Contacts.Select(x => x.Address).FirstOrDefault();
            ViewBag.email1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.email2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.phone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            return View();
        }     
    }
}
