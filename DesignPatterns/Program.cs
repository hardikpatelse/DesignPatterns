// See https://aka.ms/new-console-template for more information
using DesignPatterns.StrategyPattern.CreditCardExample;
using DesignPatterns.StrategyPattern.DuckExample;

MallardDuck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.PerformFLy();
mallardDuck.PerformQuack();
mallardDuck.Swim();
Console.WriteLine();

RedheadDuck redheadDuck = new RedheadDuck();
redheadDuck.Display();
redheadDuck.PerformFLy();
redheadDuck.PerformQuack();
redheadDuck.Swim();
Console.WriteLine();

RubberDuck rubberDuck = new RubberDuck();
rubberDuck.Display();
rubberDuck.PerformFLy();
rubberDuck.PerformQuack();
rubberDuck.Swim();
Console.WriteLine();

DecoyDuck decoyDuck = new DecoyDuck();
decoyDuck.Display();
decoyDuck.PerformFLy();
decoyDuck.PerformQuack();
decoyDuck.Swim();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();

AxisFlipkartCard axisFlipkartCard = new AxisFlipkartCard();
axisFlipkartCard.CardName();
axisFlipkartCard.Display();
axisFlipkartCard.CalculateJoiningFee();
axisFlipkartCard.CalculateAnnualFee();
axisFlipkartCard.VerifyCardNumber();
axisFlipkartCard.VerifyCVV();
axisFlipkartCard.VerifyPin();
axisFlipkartCard.CalculateInterest(15000.00m);
axisFlipkartCard.ApplyDiscount(5500.00m);
Console.WriteLine();

ICICIAmazon iCICIAmazon = new ICICIAmazon();
iCICIAmazon.CardName();
iCICIAmazon.Display();
iCICIAmazon.CalculateJoiningFee();
iCICIAmazon.CalculateAnnualFee();
iCICIAmazon.VerifyCardNumber();
iCICIAmazon.VerifyCVV();
iCICIAmazon.VerifyPin();
iCICIAmazon.CalculateInterest(305000.00m);
iCICIAmazon.ApplyDiscount(5810.00m);
Console.WriteLine();

KotakBookMyShow kotakBookMyShow = new KotakBookMyShow();
kotakBookMyShow.CardName();
kotakBookMyShow.Display();
kotakBookMyShow.CalculateJoiningFee();
kotakBookMyShow.CalculateAnnualFee();
kotakBookMyShow.VerifyCardNumber();
kotakBookMyShow.VerifyCVV();
kotakBookMyShow.VerifyPin();
kotakBookMyShow.CalculateInterest(1500.00m);
kotakBookMyShow.ApplyDiscount(500.00m);
Console.WriteLine();

HSBCIndianOil hSBCIndianOil = new HSBCIndianOil();
hSBCIndianOil.CardName();
hSBCIndianOil.Display();
hSBCIndianOil.CalculateJoiningFee();
hSBCIndianOil.CalculateAnnualFee();
hSBCIndianOil.VerifyCardNumber();
hSBCIndianOil.VerifyCVV();
hSBCIndianOil.VerifyPin();
hSBCIndianOil.CalculateInterest(15400.00m);
hSBCIndianOil.ApplyDiscount(2000.00m);
Console.WriteLine();

Console.ReadLine();