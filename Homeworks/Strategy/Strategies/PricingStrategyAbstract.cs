namespace Strategy.Strategies
{
    public abstract class PricingStrategyAbstract
    {
        public decimal PricePerHour { get; set; }
        public abstract decimal CalculateBookingPrice(int hours, int peopleCount, bool isExternal);
    }
}
