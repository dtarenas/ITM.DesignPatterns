using Observer.Subscriber;

namespace Observer.Publisher
{
    public interface IPublisher
    {
        void Subscribe(SubscriberAbstract subscriber);
        void Unsubscribe(SubscriberAbstract subscriber);
        void NotifySubscribers();
        IList<SubscriberAbstract> GetSubscribers();
    }
}
