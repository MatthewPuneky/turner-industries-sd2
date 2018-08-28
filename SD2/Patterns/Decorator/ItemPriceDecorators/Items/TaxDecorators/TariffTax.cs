using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items.TaxDecorators
{
    public class TariffTax : ItemPriceDecorator
    {
        private double _tariffTax = 0.03;

        public override double CalculatePrice()
        {
            var curCost = base.CalculatePrice();
            return curCost * (1 + _tariffTax);
        }
    }
}
