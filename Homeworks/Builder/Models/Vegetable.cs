namespace Builder.Models
{
    public class Vegetable
    {
        public Vegetable(VegetableType vegetableType)
        {
            Type = vegetableType;
        }

        public VegetableType Type { get; set; }
        public decimal GetPrice()
        {
            return this.Type switch
            {
                VegetableType.Tomato => 2500,
                VegetableType.Lettuce => 1800,
                VegetableType.Cucumber => 3000,
                _ => 1000 // Default price if cheese type is not explicitly listed
            };
        }
    }
}
