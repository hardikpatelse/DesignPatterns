using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Strategy.FlyBehavior
{
    //Common FLy Behavior Implementation (Regular Flying)
    internal class FlyWithWings : IFLyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(@"I'm Flying!");
        }
    }
}
