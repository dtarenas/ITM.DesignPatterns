namespace Strategy.Strategies
{
    public class RecreationalStrategy : PricingStrategyAbstract
    {
        public RecreationalStrategy()
        {
            this.PricePerHour = 5000m;
        }

        public override decimal CalculateBookingPrice(int hours, int peopleCount, bool isExternal)
        {
            PrintTrace($"+++-----  RecreationalStrategy  -----+++");
            PrintTrace($"Price per hour: {this.PricePerHour:C}");
            var basePrice = this.PricePerHour * hours;
            if (!isExternal)
            {
                PrintTrace("If internal no taxes");
                PrintTrace($"Total Price: {basePrice:C}");
                return basePrice;
            }

            PrintTrace("Additional 10% charge if persons > 6");
            var extraCharge = peopleCount > 6 ? 10 : 0;
            var totalPercentageAdjustment = extraCharge / 100m;
            var adjustedPrice = basePrice * (1 + totalPercentageAdjustment);

            PrintTrace($"Total Price: {adjustedPrice:C}");
            return adjustedPrice;
        }

        private void PrintTrace(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
