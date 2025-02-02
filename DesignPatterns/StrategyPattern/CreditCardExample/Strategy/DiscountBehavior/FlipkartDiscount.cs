using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior
{
    internal class FlipkartDiscount : IDiscountBehavior
    {
        private readonly decimal _discountPercent;
        public FlipkartDiscount(decimal discountPercent)
        {
            _discountPercent = discountPercent;
        }
        public decimal Discount(decimal amount)
        {
            Console.WriteLine(@"Flipkart Discount of {0} % on Rs. {1}", _discountPercent, amount);
            return amount * _discountPercent;
        }
    }
}
