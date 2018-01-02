﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValueScreener.Models.Domain;

namespace ValueScreener.ViewComponents
{
    public class IncomeStatementViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(
            Stock stock)
        {

            return View(stock);
        }
    }
}
