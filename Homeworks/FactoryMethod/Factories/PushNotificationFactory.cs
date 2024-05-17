using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    internal class PushNotificationFactory : NotificationAbstractFactory
    {
        public override NotificationAbstract Notification()
        {
            return new PushNotification();
        }
    }
}
