namespace FactoryMethod.Products
{
    public class WhatsAppNotification : NotificationAbstract
    {
        public override void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calling WhatsApp's API");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine("Notification has been sent via WhatsApp!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
