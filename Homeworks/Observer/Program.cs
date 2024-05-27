using Observer.Publisher;
using Observer.Subscriber;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reservationPublisher = new ReservationPublisher();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's create subscribers");
            Console.WriteLine("--------------------------------");
            while (true)
            {
                Console.WriteLine("Set name");
                var name = Console.ReadLine();
                Console.WriteLine($"Set User Type ({string.Join(", ", PrintEnumValues<UserType>())}): ");
                var type = Console.ReadLine();
                var subscriber = new UserSubscriber(name, Enum.Parse<UserType>(type));
                reservationPublisher.Subscribe(subscriber);

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Do you want to add a new subscriber? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Environment.NewLine);
                    break;
                }

                Console.WriteLine(Environment.NewLine);
            }

            ModifyReservationStatus(reservationPublisher);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Let's modify subscribers");
            Console.WriteLine("--------------------------------");
            while (true)
            {
                Console.WriteLine("Do you want unsubscribe someone? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Environment.NewLine);
                    break;
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Choose the subscriber ID: {string.Join(", ", reservationPublisher.GetSubscribers().Select(s => s.Id))}");
                var id = Console.ReadLine();
                var subscriber = reservationPublisher.GetSubscribers().First(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
                reservationPublisher.Unsubscribe(subscriber);
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            ModifyReservationStatus(reservationPublisher);
            Console.ResetColor();
        }

        private static void ModifyReservationStatus(ReservationPublisher reservationPublisher)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Let's modify the Reservation Status");
            Console.WriteLine("--------------------------------");
            while (true)
            {
                Console.WriteLine($"Set Reservation Status ({string.Join(", ", PrintEnumValues<ReservationStatus>())}): ");
                var reservationStatuus = Console.ReadLine();
                reservationPublisher.UpdateReservationStatus(Enum.Parse<ReservationStatus>(reservationStatuus));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Do you want set a new Reservation status? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Environment.NewLine);
                    break;
                }

                Console.WriteLine(Environment.NewLine);
            }
        }

        private static List<string> PrintEnumValues<T>() where T : Enum
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
