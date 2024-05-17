using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class WhatsAppNotificationFactory : NotificationAbstractFactory
    {
        public override NotificationAbstract Notification()
        {
            return new WhatsAppNotification();
        }
    }
}
