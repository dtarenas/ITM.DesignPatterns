namespace Observer.Subscriber
{
    public class UserSubscriber : SubscriberAbstract
    {
        public string Name { get; set; }
        public UserType UserType { get; set; }

        public UserSubscriber(string name, UserType userType)
        {
            this.UserType = userType;
            this.Name = name;
            this.Id = Guid.NewGuid().ToString().Substring(1, 4);
        }

        public override void Update(string message)
        {
            Console.WriteLine($"Hi! {this.Id} - {this.UserType} - {this.Name}, you have a new notification: {message}");
        }
    }
}
