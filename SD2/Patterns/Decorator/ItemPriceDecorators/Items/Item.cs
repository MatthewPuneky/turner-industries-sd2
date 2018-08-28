using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items
{
    public abstract class Item
    {
        public abstract string ItemName { get; }
        public virtual double ItemPrice { get; }

        public abstract double CalculatePrice();
    }
}
