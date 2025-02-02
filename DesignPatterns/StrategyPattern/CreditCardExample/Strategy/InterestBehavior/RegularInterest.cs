using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior
{
    internal class RegularInterest : IInterestBehavior
    {
        public decimal CalculateInterest(decimal balance)
        {
            return balance * 0.15m; // 15% interest
        }
    }
}
