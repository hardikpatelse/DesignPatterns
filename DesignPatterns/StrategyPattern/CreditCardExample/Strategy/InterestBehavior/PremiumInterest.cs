using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior
{
    internal class PremiumInterest : IInterestBehavior
    {
        public decimal CalculateInterest(decimal balance)
        {
            return balance * 0.10m; // 10% interest
        }
    }
}
