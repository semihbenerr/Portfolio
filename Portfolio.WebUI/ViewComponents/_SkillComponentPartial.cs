﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.WebUI.DAL.Context;

namespace MyPortfolio.WebUI.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
