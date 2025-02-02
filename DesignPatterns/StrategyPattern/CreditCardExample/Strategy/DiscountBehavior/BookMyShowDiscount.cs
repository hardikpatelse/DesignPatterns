using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior
{
    internal class BookMyShowDiscount : IDiscountBehavior
    {
        private readonly decimal _discountPercent;
        public BookMyShowDiscount(decimal discountPercent)
        {
            _discountPercent = discountPercent;
        }
        public decimal Discount(decimal amount)
        {
            Console.WriteLine(@"BookMyShow Discount of {0} % on {1}, if minimum 4 tickets are booked.", _discountPercent, amount);
            return amount * _discountPercent;
        }
    }
}
