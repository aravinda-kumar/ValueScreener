﻿using ValueScreener.Controllers.ScreenerColumns;
using ValueScreener.Models.Domain;
using ValueScreener.Models.ViewModels;

namespace ValueScreener.Controllers.ScreenerCriteria
{
    class AvgRoeScreenerCriteria : AbstractCriteria
    {
        public override string Id => ColumnConstants.AvgRoe;
        public override string DisplayName => ColumnConstants.AvgRoeDisplay;
        public override CellKind ValueType => CellKind.Percentage;
        public override string DefaultOperator => CriteriaConstants.Greater;
        protected override decimal GetDecimalValue(Stock stock)
        {
            return stock.PricingResult.AverageRoe;
        }

        protected override string GetStringValue(Stock stock)
        {
            return null;
        }
    }
}