using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Decorator.ItemPriceDecorators.Items.TaxDecorators;

namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items.SaleDecorators
{
    public class ClearancePriceDecorator : ItemPriceDecorator
    {
        private double _clearanceSale = 0.2;

        public override double CalculatePrice()
        {
            var curCost = base.CalculatePrice();
            return curCost * (1 - _clearanceSale);
        }
    }
}
