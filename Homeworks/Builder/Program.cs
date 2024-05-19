using Builder.Builder;
using Builder.Models;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director.Director();
            var burgerBuilder = new BurgerBuilder();
            var traditionalBurger = director.ConstructTraditionalBurger(burgerBuilder);
            var burger = traditionalBurger.Build();
            burger.MakeBurger();
            Console.WriteLine(Environment.NewLine);
            var vegetarianBurger = director.ConstructVegetarianBurger(burgerBuilder);
            burger = vegetarianBurger.Build();
            burger.MakeBurger();
            Console.WriteLine(Environment.NewLine);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            burgerBuilder.Reset();
            Console.WriteLine("Let's build your burger!");
            Console.WriteLine("--------------------------------");
            Console.Write("Set the burger's name: ");
            string name = Console.ReadLine();
            burgerBuilder.SetName(name);

            Console.Write($"Choose your bread ({string.Join(", ", PrintEnumValues<BreadType>())}): ");
            string bread = Console.ReadLine();
            burgerBuilder.SetBread(Enum.Parse<BreadType>(bread));

            Console.Write($"Choose your meat ({string.Join(", ", PrintEnumValues<MeatType>())}): ");
            string meat = Console.ReadLine();
            burgerBuilder.SetMeat(Enum.Parse<MeatType>(meat));

            Console.Write($"Choose your cheese ({string.Join(", ", PrintEnumValues<CheeseType>())}): ");
            string cheese = Console.ReadLine();
            burgerBuilder.SetCheese(Enum.Parse<CheeseType>(cheese));
            Console.WriteLine($"INFO: Add a Vegetable (wirte 'done' to finish the adding): ");
            while (true)
            {
                Console.Write($"Add a Vegetable ({string.Join(", ", PrintEnumValues<VegetableType>())}): ");
                string vegetable = Console.ReadLine();
                if (vegetable.Equals("done", StringComparison.CurrentCultureIgnoreCase)) break;
                burgerBuilder.SetVegetable(Enum.Parse<VegetableType>(vegetable));
            }

            Console.WriteLine($"Add a Souce (wirte 'done' to finish the adding): ");
            while (true)
            {
                Console.Write($"Add a Souce ({string.Join(", ", PrintEnumValues<SauceType>())}): ");
                string sauce = Console.ReadLine();
                if (sauce.Equals("done", StringComparison.CurrentCultureIgnoreCase)) break;
                burgerBuilder.SetSauce(Enum.Parse<SauceType>(sauce));
            }

            burgerBuilder.SetIsCustom(true);
            burger = burgerBuilder.Build();
            burger.MakeBurger();
            Console.ResetColor();
        }


        public static List<string> PrintEnumValues<T>() where T : Enum
        {
            var listValues = new List<string>();
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                listValues.Add($"{(int)value}: {Enum.GetName(typeof(T), value)}");
            }

            return listValues;
        }
    }
}
