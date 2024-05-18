namespace Builder.Models
{
    public class Bread
    {
        public BreadType Type { get; set; }

        public decimal GetPrice()
        {
            return this.Type switch
            {
                BreadType.White => 5000,
                BreadType.WholeWheat => 6800,
                BreadType.Cassava => 8300,
                _ => 10000 // Default price if cheese type is not explicitly listed
            };
        }
    }
}
