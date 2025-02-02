namespace DesignPatterns.StrategyPattern.CreditCardExample.Interface
{
    internal interface IInterestBehavior
    {
        decimal CalculateInterest(decimal balance);
    }
}
