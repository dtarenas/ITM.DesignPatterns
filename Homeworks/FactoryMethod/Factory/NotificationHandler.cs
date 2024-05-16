using FactoryMethod.Factory.Products;

namespace FactoryMethod.Factory
{
    public abstract class NotificationHandler
    {
        public abstract INotification Notification();

        public void DoNotification()
        {
            var notification = Notification();
            notification.Send();
        }

    }
}
