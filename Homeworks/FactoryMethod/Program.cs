using FactoryMethod.Factories;

namespace FactoryMethod
{
    internal class Program
    {
        private static NotificationAbstractFactory notificationHandler;

        /// <summary>
        /// Factories the configuration.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void FactoryConfig(NotificationType type)
        {
            notificationHandler = type switch
            {
                NotificationType.WhatsApp => new WhatsAppNotificationFactory(),
                NotificationType.Email => new EmailNotificationFactory(),
                NotificationType.Push => new PushNotificationFactory(),
                _ => throw new ArgumentException("Notification Type is not handled")
            };
        }

        public static void RunFactory(NotificationType type)
        {
            FactoryConfig(type);
            notificationHandler.SendNotification("Hello Moto");
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Choose your notification Type ({string.Join(", ", PrintEnumValues<NotificationType>())}): ");
                string userValue = Console.ReadLine();
                if (userValue.ToLower() == "done") { break; }
                var notificationType = Enum.Parse<NotificationType>(userValue);
                RunFactory(notificationType);
                Console.WriteLine(Environment.NewLine);

            }
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
