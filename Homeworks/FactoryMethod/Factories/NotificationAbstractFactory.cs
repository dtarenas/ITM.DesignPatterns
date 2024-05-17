using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public abstract class NotificationAbstractFactory
    {
        public abstract NotificationAbstract Notification();

        public void SendNotification(string message)
        {
            var notification = Notification();
            notification.Send(message);
        }

    }
}
