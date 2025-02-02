using DesignPatterns.StrategyPattern.CreditCardExample.Interface;

namespace DesignPatterns.StrategyPattern.CreditCardExample.Abstract
{
    internal abstract class CreditCard
    {
        IAnnualFeeBehavior _annualFeeBehavior;
        IJoiningFeeBehavior _joiningFeeBehavior;
        IInterestBehavior _interestBehavior;
        IDiscountBehavior _discountBehavior;

        public void SetAnnualFee(IAnnualFeeBehavior annualFeeBehavior)
        {
            _annualFeeBehavior = annualFeeBehavior;
        }

        public void SetJoiningFee(IJoiningFeeBehavior joiningFeeBehavior)
        {
            _joiningFeeBehavior = joiningFeeBehavior;
        }

        public void SetInterestBehavior(IInterestBehavior interestBehavior)
        {
            _interestBehavior = interestBehavior;
        }

        public void SetDiscountBehavior(IDiscountBehavior discountBehavior)
        {
            _discountBehavior = discountBehavior;
        }

        public void CalculateAnnualFee()
        {
            _annualFeeBehavior.AnnualFee();
        }

        public void CalculateJoiningFee()
        {
            _joiningFeeBehavior.JoiningFee();
        }

        public decimal CalculateInterest(decimal balance)
        {
            return _interestBehavior.CalculateInterest(balance);
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return _discountBehavior.Discount(amount);
        }

        public void VerifyCardNumber() 
        {
            Console.WriteLine(@"Card Verified!");
        }
        public void VerifyCVV() 
        {
            Console.WriteLine(@"CVV Verified!");
        }
        public void VerifyPin() 
        {
            Console.WriteLine(@"Pin Verified!");
        }
        public abstract void Display();
        public abstract void CardName();
    }
}
