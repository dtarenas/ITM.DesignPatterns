namespace FactoryMethod.Factory.Products
{
    public class WhatsAppNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Notification has been sent via WhatsApp!");
        }
    }
}
