﻿using ValueScreener.Controllers.ScreenerColumns;
using ValueScreener.Models.Domain;
using ValueScreener.Models.ViewModels;

namespace ValueScreener.Controllers.ScreenerCriteria
{
    class CountryCriteria : AbstractCriteria
    {
        public override string Id =>  ColumnConstants.Country;
        public override string DisplayName => ColumnConstants.CountryDisplay;
        public override CellKind ValueType => CellKind.Text;
        public override string DefaultOperator => CriteriaConstants.Different;
        protected override decimal GetDecimalValue(Stock stock)
        {
            return 0;
        }

        protected override string GetStringValue(Stock stock)
        {
            return stock.Country;
        }
    }
}