namespace FactoryMethod.Products
{
    public class PushNotification : NotificationAbstract
    {
        public override void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Stablish connection to Firebase");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine("Notification has been sent via Push!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
