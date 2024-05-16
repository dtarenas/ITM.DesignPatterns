using FactoryMethod.Factory.Products;

namespace FactoryMethod.Factory
{
    internal class EmailNotificationHandler : NotificationHandler
    {
        public override INotification Notification()
        {
            return new EmailNotification();
        }
    }
}
