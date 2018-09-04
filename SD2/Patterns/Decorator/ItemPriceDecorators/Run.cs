using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Decorator.ItemPriceDecorators.Items;
using SD2.Patterns.Decorator.ItemPriceDecorators.Items.SaleDecorators;
using SD2.Patterns.Decorator.ItemPriceDecorators.Items.TaxDecorators;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Decorator.ItemPriceDecorators
{
    public static class Run
    {
        public static void Operation()
        {
            var banana = new Banana();

            var tariffTax = new TariffTax();
            var salesTax = new SalesTax();
            var clearanceSale = new ClearancePriceDecorator();

            clearanceSale.SetItem(banana);
            salesTax.SetItem(clearanceSale);
            tariffTax.SetItem(salesTax);

            Printer.PrintLine($"{tariffTax.CalculatePrice()}");
        }
    }
}
