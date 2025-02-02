using DesignPatterns.StrategyPattern.DuckExample.Abstract;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.FlyBehavior;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior;

namespace DesignPatterns.StrategyPattern.DuckExample
{
    //A Concrete Rubber Duck
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeak());
        }
        public override void Display()
        {
            Console.WriteLine(@"I'm a real Rubber Duck!");
        }
    }
}
