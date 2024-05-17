namespace FactoryMethod.Products
{
    internal class EmailNotification : NotificationAbstract
    {
        public override void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Getting SMTP configuration");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine("Notification has been sent via Email!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
