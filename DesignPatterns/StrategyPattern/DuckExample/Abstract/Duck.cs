using DesignPatterns.StrategyPattern.DuckExample.Interface;

namespace DesignPatterns.StrategyPattern.DuckExample.Abstract
{
    //The Duck Super Class
    internal abstract class Duck
    {
        private IFLyBehavior _fLyBehavior;
        private IQuackBehavior _quackBehavior;

        public void SetFlyBehavior(IFLyBehavior fLyBehavior)
        {
            _fLyBehavior = fLyBehavior;
        }

        public void PerformFLy()
        {
            _fLyBehavior.Fly();
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void PerformQuack()
        {
            _quackBehavior.Says();
        }

        public void Swim()
        {
            Console.WriteLine(@"I can Swim!!!");
        }

        public abstract void Display();
    }
}
