namespace Observer.Subscriber
{
    public abstract class SubscriberAbstract
    {
        public string Id { get; set; }
        public abstract void Update(string message);
    }
}
