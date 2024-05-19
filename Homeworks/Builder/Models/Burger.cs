namespace Builder.Models
{
    public class Burger
    {
        public string Name { get; set; }
        public Bread Bread { get; set; } = new();
        public Meat Meat { get; set; } = new();
        public Cheese Cheese { get; set; } = new();
        public List<Vegetable> Vegetables { get; set; } = [];
        public List<Sauce> Sauces { get; set; } = [];
        public bool IsCustom { get; set; }

        public Burger()
        {
        }

        public Burger(string name, Bread bread, Meat meat, Cheese cheese, List<Vegetable> vegetables, List<Sauce> sauces, bool isCustom)
        {
            this.Name = name;
            this.Bread = bread;
            this.Meat = meat;
            this.Cheese = cheese;
            this.Vegetables = vegetables;
            this.Sauces = sauces;
            this.IsCustom = isCustom;
        }

        public void MakeBurger()
        {
            Console.WriteLine($"New Order --- Enjoy it");
            Console.WriteLine($"Buger Name: {this.Name}");
            Console.WriteLine($"Bread: {this.Bread.Type} - Price: {this.Bread.GetPrice():C}");
            Console.WriteLine($"Meat: {this.Meat.Type} - Price: {this.Meat.GetPrice():C}");
            Console.WriteLine($"Cheese: {this.Cheese.Type} - Price: {this.Cheese.GetPrice():C}");
            Console.WriteLine($"Vegetables: {string.Join(", ", this.Vegetables.Select(x => $"{x.Type} - Price: {x.GetPrice():C}"))}");
            Console.WriteLine($"Sauces: {string.Join(", ", this.Sauces.Select(x => $"{x.Type} - Price: {x.GetPrice():C}"))}");
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Total Price: {this.GetTotalPrice()}");
        }

        private string GetTotalPrice()
        {
            var totalPrice = this.Bread.GetPrice() +
                this.Meat.GetPrice() +
                this.Cheese.GetPrice() +
                this.Vegetables.Sum(x => x.GetPrice()) +
                this.Sauces.Sum(x => x.GetPrice());

            totalPrice = this.IsCustom ? totalPrice * (1.1m) : totalPrice;
            return totalPrice.ToString("C");
        }
    }
}
