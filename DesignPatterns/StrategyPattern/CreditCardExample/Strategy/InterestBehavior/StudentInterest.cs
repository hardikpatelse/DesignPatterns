using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior
{
    internal class StudentInterest : IInterestBehavior
    {
        public decimal CalculateInterest(decimal balance)
        {
            return balance * 0.05m; // 5% interest
        }
    }
}
