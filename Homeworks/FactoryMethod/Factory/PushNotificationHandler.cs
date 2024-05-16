using FactoryMethod.Factory.Products;

namespace FactoryMethod.Factory
{
    internal class PushNotificationHandler : NotificationHandler
    {
        public override INotification Notification()
        {
            return new PushNotification();
        }
    }
}
