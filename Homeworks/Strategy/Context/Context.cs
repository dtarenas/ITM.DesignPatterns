using Strategy.Strategies;

namespace Strategy.Context
{
    public class Context
    {
        private readonly PricingStrategyAbstract _strategy;

        public Context(PricingStrategyAbstract strategy)
        {
            this._strategy = strategy;
        }

        public decimal ExecuteStrategy(int hours, int peopleCount, bool isExternal)
        {
            return this._strategy.CalculateBookingPrice(hours, peopleCount, isExternal);
        }
    }
}
