namespace FactoryMethod.Factory.Products
{
    internal class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Notification has been sent via Email!");
        }
    }
}
