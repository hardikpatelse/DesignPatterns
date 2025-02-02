using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior
{
    internal class FixedAnnualFee : IAnnualFeeBehavior
    {
        private double _annualFees = 0.00;
        public FixedAnnualFee(double annalFees)
        {
            _annualFees = annalFees;
        }
        public void AnnualFee()
        {
            Console.WriteLine(@"Fixed Annual Fees of Rs. {0}", _annualFees);
        }
    }
}
