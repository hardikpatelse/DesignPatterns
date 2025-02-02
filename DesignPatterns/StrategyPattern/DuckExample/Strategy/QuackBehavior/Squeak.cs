using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior
{
    //Common Quack Behavior Implementation (Squeaking)
    internal class Squeak : IQuackBehavior
    {
        public void Says()
        {
            Console.WriteLine(@"I'm Squeaking!");
        }
    }
}
