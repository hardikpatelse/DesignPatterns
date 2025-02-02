using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior
{
    internal class IndianOilDiscount : IDiscountBehavior
    {
        public decimal Discount(decimal amount)
        {
            Console.WriteLine(@"Indian Oil Offers a 1% fuel surcharge waiver.");
            return amount * 0.01m; // 1% fuel surcharge waiver
        }
    }
}
