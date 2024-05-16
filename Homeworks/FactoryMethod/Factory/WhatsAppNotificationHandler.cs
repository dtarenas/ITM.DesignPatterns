using FactoryMethod.Factory.Products;

namespace FactoryMethod.Factory
{
    public class WhatsAppNotificationHandler : NotificationHandler
    {
        public override INotification Notification()
        {
            return new WhatsAppNotification();
        }
    }
}
