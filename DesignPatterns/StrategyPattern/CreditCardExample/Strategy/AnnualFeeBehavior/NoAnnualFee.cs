using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.AnnualFeeBehavior
{
    internal class NoAnnualFee : IAnnualFeeBehavior
    {
        public void AnnualFee()
        {
            Console.WriteLine(@"Hurray!!! No Annual Fees!");
        }
    }
}
