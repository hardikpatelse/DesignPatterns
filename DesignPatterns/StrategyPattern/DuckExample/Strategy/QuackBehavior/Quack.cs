using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior
{
    //Common Quack Behavior Implementation (Regular Quacking)
    internal class Quack : IQuackBehavior
    {
        public void Says()
        {
            Console.WriteLine(@"I'm Quacking!");
        }
    }
}
