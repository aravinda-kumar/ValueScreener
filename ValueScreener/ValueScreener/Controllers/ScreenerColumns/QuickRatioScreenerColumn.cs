﻿using ValueScreener.Models.Domain;
using ValueScreener.Models.ViewModels;

namespace ValueScreener.Controllers.ScreenerColumns
{
    class QuickRatioScreenerColumn : IScreenerColumn
    {
        public string DisplayName => ColumnConstants.QuickRatioDisplay;
        public ScreenerCellViewModel GetCell(Stock stock)
        {
            var ratio = 0M;
            if (stock.PricingResult != null)
                ratio = stock.PricingResult.CurrentQuickRatio;
            return new ScreenerCellViewModel
            {
                CellKind = CellKind.Percentage,
                IsBold = false,
                IsLink = false,
                PercentageValue = ratio,
                StockId = stock.Id
            };
        }
    }
}