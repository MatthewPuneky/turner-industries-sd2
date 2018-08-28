namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items
{
    public abstract class ItemPriceDecorator : Item
    {
        protected Item Item;

        public void SetItem(Item item)
        {
            Item = item;
        }

        public override string ItemName => Item.ItemName;

        public override double CalculatePrice()
        {
            if (Item != null)
            {
                return Item.CalculatePrice();
            }

            return 0;
        }
    }
}
