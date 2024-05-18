namespace Builder.Models
{
    public class Meat
    {
        public MeatType Type { get; set; }
        public decimal GetPrice()
        {
            return this.Type switch
            {
                MeatType.Pork => 11500,
                MeatType.Chicken => 7500,
                MeatType.Vegetarian => 12500,
                _ => 1000 // Default price if cheese type is not explicitly listed
            };
        }
    }
}
