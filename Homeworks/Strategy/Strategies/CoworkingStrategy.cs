namespace Strategy.Strategies
{
    public class CoworkingStrategy : PricingStrategyAbstract
    {
        public CoworkingStrategy()
        {
            this.PricePerHour = 6000m;
        }

        public override decimal CalculateBookingPrice(int hours, int peopleCount, bool isExternal)
        {
            PrintTrace($"+++-----  CoworkingStrategy  -----+++");
            PrintTrace($"Price per hour: {this.PricePerHour:C}");
            PrintTrace("15% tax if external");
            var tax = isExternal ? 15 : 0; 
            PrintTrace("5% discount if hours > 4");
            var discount = hours > 4 ? 5 : 0; 
            PrintTrace("Additional charge of 6% if persons > 4");
            var extraCharge = peopleCount > 4 ? 6 : 0; 
            PrintTrace("Free if internal and only one person");
            var isFree = !isExternal && peopleCount == 1;

            var basePrice = this.PricePerHour * hours;
            var totalPercentageAdjustment = (tax + extraCharge - discount) / 100;
            var adjustedPrice = basePrice * (1 + totalPercentageAdjustment);
            var total = isFree ? 0 : adjustedPrice;

            PrintTrace($"Total Price: {total:C}");
            return total;
        }

        private void PrintTrace(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
