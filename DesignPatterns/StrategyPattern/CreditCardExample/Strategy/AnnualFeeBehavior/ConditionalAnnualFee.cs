using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior
{
    internal class ConditionalAnnualFee : IAnnualFeeBehavior
    {
        private readonly decimal _annualFee;
        private readonly decimal _minimumSpend;

        public ConditionalAnnualFee(decimal minimumSpend, decimal annualFee)
        {
            _annualFee = annualFee;
            _minimumSpend = minimumSpend;
        }

        public void AnnualFee()
        {
            Console.WriteLine(@"Conditional Annual Fees of Rs. {0}, if not spend minimum Rs. {1}", _annualFee, _minimumSpend);
        }
    }
}
