using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items.TaxDecorators
{
    public class SalesTax : ItemPriceDecorator
    {
        private double _stateSalesTax = 0.07;

        public override double CalculatePrice()
        {
            var curCost = base.CalculatePrice();
            return curCost * (1 + _stateSalesTax);
        }
    }
}
