using Proxy.Models;
using Proxy.Proxy;
using Proxy.Services;
using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            ICommonAreaService commonAreasProxy = new CommonAreaServiceProxy();
            var commonAreas = commonAreasProxy.GetCommonAreas();

            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's book a common Area");
            Console.WriteLine("************************");
            Console.WriteLine(Environment.NewLine);

            while (true)
            {

                Console.WriteLine($"Select a Common Area:\n{GetAvailableCommonAreas(commonAreas)}");
                var commonAreaSelectedId = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("How many hours would you like to book?");
                var hours = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("How many people will attend?");
                var peopleCount = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Are you tenant or owner? (Y/N)");
                var isExternalString = Console.ReadLine();
                var isExternal = isExternalString.Equals("N", StringComparison.OrdinalIgnoreCase);
                var commonArea = commonAreas.FirstOrDefault(c => c.Id == commonAreaSelectedId);

                //Use Strategy
                PricingStrategyAbstract strategy = commonArea.CommonAreaType switch
                {
                    Proxy.CommonAreaType.Recreational => new RecreationalStrategy(),
                    Proxy.CommonAreaType.Social => new SocialStrategy(),
                    _ => new CoworkingStrategy(),
                };

                var context = new Context.Context(strategy);
                context.ExecuteStrategy(hours, peopleCount, isExternal);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Do you want to book another common area? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Environment.NewLine);
                    break;
                }
            }
        }

        private static string GetAvailableCommonAreas(IEnumerable<CommonAreaDTO> commonAreas)
        {
            return string.Join("\n", commonAreas.Select(commonArea => $"{commonArea.Id}) {commonArea.Name} - {commonArea.CommonAreaType}"));
        }
    }
}
