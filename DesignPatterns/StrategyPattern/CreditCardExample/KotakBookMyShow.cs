using DesignPatterns.StrategyPattern.CreditCardExample.Abstract;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior;

namespace DesignPatterns.StrategyPattern.CreditCardExample
{
    internal class KotakBookMyShow : CreditCard
    {
        public KotakBookMyShow()
        {
            SetAnnualFee(new FixedAnnualFee(500.00));
            SetJoiningFee(new NoJoiningFee());
            SetInterestBehavior(new RegularInterest());
            SetDiscountBehavior(new BookMyShowDiscount(0.50m));
        }
        public override void CardName()
        {
            Console.WriteLine(@"Kotak Bank - BookMyShow Card!!!");
        }

        public override void Display()
        {
            Console.WriteLine(@"Vibrant design that uses bright colors with logo of BookMyShow!!!");
        }
    }
}
