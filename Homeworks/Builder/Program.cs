using Builder.Builder;
using Builder.Models;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director.Director();
            var burger = new BurgerBuilder();
            director.ConstructTraditionalBurger(burger);

            Console.WriteLine(Environment.NewLine);
            director.ConstructVegetarianBurger(burger);


            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            burger.Reset();
            Console.WriteLine("Let's build your burger!");
            Console.WriteLine("--------------------------------");
            Console.Write("Set the burger's name: ");
            string name = Console.ReadLine();
            burger.SetName(name);

            Console.Write($"Choose your bread ({string.Join(", ", PrintEnumValues<BreadType>())}): ");
            string bread = Console.ReadLine();
            burger.SetBread(Enum.Parse<BreadType>(bread));

            Console.Write($"Choose your meat ({string.Join(", ", PrintEnumValues<MeatType>())}): ");
            string meat = Console.ReadLine();
            burger.SetMeat(Enum.Parse<MeatType>(meat));

            Console.Write($"Choose your cheese ({string.Join(", ", PrintEnumValues<CheeseType>())}): ");
            string cheese = Console.ReadLine();
            burger.SetCheese(Enum.Parse<CheeseType>(cheese));
            Console.WriteLine($"INFO: Add a Vegetable (wirte 'done' to finish the adding): ");
            while (true)
            {
                Console.Write($"Add a Vegetable ({string.Join(", ", PrintEnumValues<VegetableType>())}): ");
                string vegetable = Console.ReadLine();
                if (vegetable.ToLower() == "done") break;
                burger.SetVegetable(Enum.Parse<VegetableType>(vegetable));
            }

            Console.Write($"Add a Souce (wirte 'done' to finish the adding): ");
            while (true)
            {
                Console.Write($"Add a Souce ({string.Join(", ", PrintEnumValues<SauceType>())}): ");
                string sauce = Console.ReadLine();
                if (sauce.ToLower() == "done") break;
                burger.SetSauce(Enum.Parse<SauceType>(sauce));
            }

            burger.Build();
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
