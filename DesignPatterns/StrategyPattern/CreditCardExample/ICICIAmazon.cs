using DesignPatterns.StrategyPattern.CreditCardExample.Abstract;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior;

namespace DesignPatterns.StrategyPattern.CreditCardExample
{
    internal class ICICIAmazon : CreditCard
    {
        public ICICIAmazon()
        {
            SetAnnualFee(new NoAnnualFee());
            SetJoiningFee(new FixedJoiningFee(500.00m));
            SetInterestBehavior(new StudentInterest());
            SetDiscountBehavior(new AmazonDiscount(0.10m));
        }
        public override void CardName()
        {
            Console.WriteLine(@"ICICI Bank - Amazon Card!!!");
        }

        public override void Display()
        {
            Console.WriteLine(@"Vibrant design that uses bright colors!!!");
        }
    }
}
