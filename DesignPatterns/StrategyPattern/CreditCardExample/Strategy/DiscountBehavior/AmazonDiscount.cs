using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior
{
    internal class AmazonDiscount : IDiscountBehavior
    {
        private readonly decimal _discountPercent;
        public AmazonDiscount(decimal discountPercent)
        {
            _discountPercent = discountPercent;
        }
        public decimal Discount(decimal amount)
        {
            Console.WriteLine(@"Amazon Discount of {0} % on Rs. {1}", _discountPercent, amount);
            return amount * _discountPercent;
        }
    }
}
