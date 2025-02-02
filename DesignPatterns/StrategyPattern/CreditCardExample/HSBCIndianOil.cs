using DesignPatterns.StrategyPattern.CreditCardExample.Abstract;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.DiscountBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.InterestBehavior;
using DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.CreditCardExample
{
    internal class HSBCIndianOil : CreditCard
    {
        public HSBCIndianOil()
        {
            SetAnnualFee(new ConditionalAnnualFee(25000.00m, 1000.00m));
            SetJoiningFee(new NoJoiningFee());
            SetInterestBehavior(new PremiumInterest());
            SetDiscountBehavior(new IndianOilDiscount());
        }
        public override void CardName()
        {
            Console.WriteLine(@"HSBC Bank - BookMyShow Card!!!");
        }

        public override void Display()
        {
            Console.WriteLine(@"A design that uses geometric patterns!!!");
        }
    }
}
