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


        /// <summary>
        /// Runs the factory.
        /// </summary>
        public static void RunFactory()
        {
            FactoryConfig(NotificationType.WhatsApp);
            notificationHandler.SendNotification("Hello Moto");
            Console.WriteLine(Environment.NewLine);
            FactoryConfig(NotificationType.Email);
            notificationHandler.SendNotification("Hello Moto");
            Console.WriteLine(Environment.NewLine);
            FactoryConfig(NotificationType.Push);
            notificationHandler.SendNotification("Hello Moto");
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            RunFactory();
        }
    }
}
