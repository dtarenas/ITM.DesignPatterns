namespace Strategy.Strategies
{
    public class SocialStrategy : PricingStrategyAbstract
    {
        public SocialStrategy()
        {
            this.PricePerHour = 14000m;
        }

        public override decimal CalculateBookingPrice(int hours, int peopleCount, bool isExternal)
        {
            PrintTrace($"+++-----  SocialStrategy  -----+++");
            PrintTrace($"Price per hour: {this.PricePerHour:C}");

            PrintTrace("7% tax if external");
            var tax = isExternal ? 7 : 0;
            PrintTrace("Additional charge of 5% if persons > 15");
            var extraCharge = peopleCount > 15 ? 5 : 0;
            PrintTrace("Additional 2% charge if hours > 6");
            var hourCharge = hours > 6 ? 2 : 0;

            var basePrice = this.PricePerHour * hours;
            var totalPercentageAdjustment = (tax + extraCharge + hourCharge) / 100m;
            var adjustedPrice = basePrice * (1 + totalPercentageAdjustment);

            PrintTrace($"Total Price: {adjustedPrice:C}");
            return adjustedPrice;
        }

        private void PrintTrace(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
