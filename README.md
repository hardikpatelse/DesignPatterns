# Design Patterns

Design patterns are proven solutions to recurring problems in software design. They represent best practices used by experienced software developers and provide templates for solving common design challenges. By using design patterns, developers can create more maintainable, reusable, and scalable code.

## Why Use Design Patterns?
- **Code Reusability:** Promotes reuse of existing solutions.
- **Maintainability:** Makes code easier to modify and maintain.
- **Scalability:** Helps design scalable systems.
- **Communication:** Provides a shared language among developers.
- **Best Practices:** Encourages adherence to best design principles.

Design patterns are broadly categorized into three types:
1. **Creational Patterns:** Focus on object creation mechanisms.
2. **Structural Patterns:** Deal with object composition and relationships.
3. **Behavioral Patterns:** Concerned with communication between objects.

---

# Strategy Design Pattern

## Overview
The **Strategy Design Pattern** is a behavioral design pattern that allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. It enables the algorithm to vary independently from the clients that use it.

This pattern is particularly useful when you have multiple ways to perform an operation, and you want to select the appropriate algorithm at runtime.

### Key Components
1. **Context:** Maintains a reference to a Strategy object and allows the strategy to be set or changed.
2. **Strategy Interface:** Defines a common interface for all supported algorithms.
3. **Concrete Strategies:** Implement the different variations of the algorithm.

### Benefits
- **Open/Closed Principle:** Easy to introduce new algorithms without changing existing code.
- **Code Reusability:** Algorithms are separated into distinct classes.
- **Improved Maintenance:** Easier to manage and extend algorithms.

### Example Usage
Consider a payment processing system where you can pay using different methods, such as credit cards, PayPal, or bank transfers.

```csharp
using System;

// Strategy Interface
public interface IPaymentStrategy
{
    void Pay(int amount);
}

// Concrete Strategy for Credit Card Payment
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

// Concrete Strategy for PayPal Payment
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

// Context Class
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void PayAmount(int amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        context.SetPaymentStrategy(new CreditCardPayment());
        context.PayAmount(100);

        context.SetPaymentStrategy(new PayPalPayment());
        context.PayAmount(200);
    }
}
```

### When to Use
- When multiple algorithms are available for a specific task.
- When you want to avoid conditional statements for algorithm selection.
- When you need to switch algorithms at runtime.

### Real-World Examples
- Payment processing systems.
- Sorting algorithms with dynamic selection.
- File compression utilities.

This repository currently contains code samples in **C#** demonstrating the Strategy Design Pattern. More design pattern examples will be added to provide a comprehensive reference for software design principles.

