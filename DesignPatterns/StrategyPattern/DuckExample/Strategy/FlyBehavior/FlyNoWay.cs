using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Strategy.FlyBehavior
{
    //Common FLy Behavior Implementation (Duck can't fly)
    internal class FlyNoWay : IFLyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(@"I can't FLy!!!");
        }
    }
}
