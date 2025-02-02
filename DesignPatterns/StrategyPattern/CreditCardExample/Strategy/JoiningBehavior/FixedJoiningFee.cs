using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Strategy.JoiningBehavior
{
    internal class FixedJoiningFee : IJoiningFeeBehavior
    {
        private readonly decimal _joiningFee;
        public FixedJoiningFee(decimal joiningFee)
        {
            _joiningFee = joiningFee;
        }
        public void JoiningFee()
        {
            Console.WriteLine(@"Fixed Joining Fees of Rs. {0}", _joiningFee);
        }
    }
}
