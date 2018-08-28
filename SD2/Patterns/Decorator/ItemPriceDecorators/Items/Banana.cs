namespace SD2.Patterns.Decorator.ItemPriceDecorators.Items
{
    public class Banana : Item
    {
        public override string ItemName { get; } = "Banana";
        public override double ItemPrice { get; } = 1.00;

        public override double CalculatePrice()
        {
            return ItemPrice;
        }
    }
}
