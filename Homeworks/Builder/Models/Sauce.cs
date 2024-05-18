namespace Builder.Models
{
    public class Sauce
    {
        public Sauce(SauceType sauceType)
        {
            Type = sauceType;
        }

        public SauceType Type { get; set; }
        public decimal GetPrice()
        {
            return Type switch
            {
                SauceType.Ketchup => 2000,
                SauceType.Mustard => 1500,
                SauceType.Pineapple => 3000,
                _ => 1000 // Default price if cheese type is not explicitly listed
            };
        }
    }
}
