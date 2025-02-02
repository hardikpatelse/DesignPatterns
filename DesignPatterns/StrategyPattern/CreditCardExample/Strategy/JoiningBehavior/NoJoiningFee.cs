using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior
{
    internal class NoJoiningFee : IJoiningFeeBehavior
    {
        public void JoiningFee()
        {
            Console.WriteLine(@"Hurray!!! No Joining Fees!");
        }
    }
}
