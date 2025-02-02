using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior
{
    //Common Quack Behavior Implementation (Don't Quack)
    internal class Mute : IQuackBehavior
    {
        public void Says()
        {
            Console.WriteLine(@"I don't Quack!");
        }
    }
}
