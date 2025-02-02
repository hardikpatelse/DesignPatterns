using DesignPatterns.StrategyPattern.CreditCardExample.Abstract;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior;

namespace DesignPatterns.StrategyPattern.CreditCardExample
{
    internal class AxisFlipkartCard : CreditCard
    {
        public AxisFlipkartCard()
        {
            SetAnnualFee(new NoAnnualFee());
            SetJoiningFee(new NoJoiningFee());
            SetInterestBehavior(new PremiumInterest());
            SetDiscountBehavior(new FlipkartDiscount(0.05m));
        }
        public override void CardName()
        {
            Console.WriteLine(@"Axis Bank - Flipkart Card!!!");
        }

        public override void Display()
        {
            Console.WriteLine(@"Stunning matte finishing Card!!!");
        }
    }
}
