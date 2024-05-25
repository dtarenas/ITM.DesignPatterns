using Proxy.Models;
using Proxy.Proxy;
using Proxy.Services;
using System.Diagnostics;

namespace Proxy
{
    internal class Program
    {
        private static readonly Stopwatch _stopwatch = new();
        private static readonly Stopwatch _timer = new();

        private static void Main(string[] args)
        {
            ICommonAreaService commonAreasProxy = new CommonAreaServiceProxy();
            CallService(commonAreasProxy, ConsoleColor.White);
            _timer.Start();

            ///Cached call
            CallService(commonAreasProxy, ConsoleColor.Yellow);

            Console.WriteLine(Environment.NewLine);
            while (true)
            {
                Console.WriteLine("Try a new request (Y: Yes / N: No)");
                var input = Console.ReadLine();
                if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    CallService(commonAreasProxy, ConsoleColor.Green);
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Total Elapsed time: {_timer.Elapsed.Minutes:00}:{_timer.Elapsed.Seconds:00}:{_timer.Elapsed.Milliseconds:000}");
            }

            Console.ResetColor();
            _timer.Stop();
        }

        private static void CallService(ICommonAreaService commonAreasService, ConsoleColor consoleColor)
        {
            _stopwatch.Reset();
            Console.WriteLine(Environment.NewLine);

            _stopwatch.Start();
            var commonAreas = commonAreasService.GetCommonAreas();
            PrintCommonAreas(commonAreas, consoleColor);
            _stopwatch.Stop();
            Console.WriteLine($"Service call elapsed Time: {_stopwatch.Elapsed.TotalMinutes:00}:{_stopwatch.Elapsed.TotalSeconds:00}:{_stopwatch.Elapsed.TotalMilliseconds:000}");
        }

        private static void PrintCommonAreas(IEnumerable<CommonAreaDTO> commonAreas, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            foreach (var commonArea in commonAreas)
            {
                Console.WriteLine($"ID: {commonArea.Id} Code: {commonArea.Code} Name: {commonArea.Name}");
                Console.WriteLine($"Description: {commonArea.Description}");
                Console.WriteLine($"Image Url: {commonArea.ImageUrl}");
                Console.WriteLine("------------------------------------");
            }
            Console.ResetColor();
        }
    }
}