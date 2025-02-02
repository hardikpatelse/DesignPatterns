using DesignPatterns.StrategyPattern.DuckExample.Abstract;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.FlyBehavior;
using DesignPatterns.StrategyPattern.DuckExample.Strategy.QuackBehavior;

namespace DesignPatterns.StrategyPattern.DuckExample
{
    //A Concrete Decoy Duck
    internal class DecoyDuck : Duck
    {
        public DecoyDuck() {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Mute());
        }
        public override void Display()
        {
            Console.WriteLine(@"I'm a real Decoy Duck!");
        }
    }
}
