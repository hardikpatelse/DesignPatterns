using DesignPatterns.StrategyPattern.DuckExample.Abstract;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.FlyBehavior;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior;

namespace DesignPatterns.StrategyPattern.DuckExample
{
    //A Concrete Mallard Duck
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
        }

        public override void Display()
        {
            Console.WriteLine(@"I'm a real Mallard Duck!");
        }
    }
}
