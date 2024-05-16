using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        private static NotificationHandler notificationHandler;

        /// <summary>
        /// Factories the configuration.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void FactoryConfig(NotificationType type)
        {
            notificationHandler = type switch
            {
                NotificationType.WhatsApp => new WhatsAppNotificationHandler(),
                NotificationType.Email => new EmailNotificationHandler(),
                NotificationType.Push => new PushNotificationHandler(),
                _ => throw new ArgumentException("Notification Type is not handled")
            };
        }


        /// <summary>
        /// Runs the factory.
        /// </summary>
        public static void RunFactory()
        {
            FactoryConfig(NotificationType.WhatsApp);
            notificationHandler.DoNotification();

            FactoryConfig(NotificationType.Email);
            notificationHandler.DoNotification();

            FactoryConfig(NotificationType.Push);
            notificationHandler.DoNotification();
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
