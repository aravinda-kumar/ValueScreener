﻿using ValueScreener.Models.Domain;
using ValueScreener.Models.ViewModels;

namespace ValueScreener.Controllers.ScreenerColumns
{
    class AvgGrossMarginScreenerColumn : IScreenerColumn
    {
        public string DisplayName => ColumnConstants.AvgGrossMarginDisplay;
        public ScreenerCellViewModel GetCell(Stock stock)
        {
            var ratio = 0M;
            if (stock.PricingResult != null)
                ratio = stock.PricingResult.AverageGrossMargin;
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