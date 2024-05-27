using Observer.Subscriber;

namespace Observer.Publisher
{
    public class ReservationPublisher : IPublisher
    {
        public ReservationStatus ReservationStatus { get; set; }

        private readonly IList<SubscriberAbstract> _subscribers = [];

        public void NotifySubscribers()
        {
            foreach (UserSubscriber subscriber in _subscribers)
            {
                if (subscriber.UserType == UserType.ResidentialUnitAdmin && this.ReservationStatus == ReservationStatus.PendingForReview)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    var message = $"New Reservation has been created ==> {this.ReservationStatus}";
                    subscriber.Update(message);
                    Console.ResetColor();
                }

                if (subscriber.UserType == UserType.Tenant && this.ReservationStatus != ReservationStatus.PendingForReview)
                {
                    Console.ForegroundColor = this.ReservationStatus == ReservationStatus.Rejected ? ConsoleColor.Red : ConsoleColor.Green;
                    var message = $"Reservation has been updated to ==> {this.ReservationStatus}";
                    subscriber.Update(message);
                    Console.ResetColor();
                }
            }
        }

        public void Subscribe(SubscriberAbstract subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        public void Unsubscribe(SubscriberAbstract subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        public void UpdateReservationStatus(ReservationStatus reservationStatus)
        {
            this.ReservationStatus = reservationStatus;
            this.NotifySubscribers();
        }

        public IList<SubscriberAbstract> GetSubscribers()
        {
            return this._subscribers;
        }
    }
}
