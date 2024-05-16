namespace FactoryMethod.Factory.Products
{
    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Notification has been sent via Push!");
        }
    }
}
