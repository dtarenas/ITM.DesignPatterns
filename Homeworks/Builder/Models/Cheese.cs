namespace Builder.Models
{
    public class Cheese
    {
        public CheeseType Type { get; set; }
        public decimal GetPrice()
        {
            return this.Type switch
            {
                CheeseType.Mozzarella => 2000,
                CheeseType.Cheddar => 1500,
                CheeseType.Vegan => 6500,
                _ => 1000 // Default price if cheese type is not explicitly listed
            };
        }
    }
}
