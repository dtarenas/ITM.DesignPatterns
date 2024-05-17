using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    internal class EmailNotificationFactory : NotificationAbstractFactory
    {
        public override NotificationAbstract Notification()
        {
            return new EmailNotification();
        }
    }
}
