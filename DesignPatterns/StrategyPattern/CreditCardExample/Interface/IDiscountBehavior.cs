namespace DesignPatterns.StrategyPattern.CreditCardExample.Interface
{
    internal interface IDiscountBehavior
    {
        decimal Discount(decimal amount);
    }
}
