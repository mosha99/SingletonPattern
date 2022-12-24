
using SingletonPattern;

Calculator calculator = Calculator.GetCalculator();

Calculator calculator2 = Calculator.GetCalculator();

Calculator calculator3 = Calculator.GetCalculator();

Calculator calculator4 = Calculator.GetCalculator();

int x1 =calculator.Sum(1);
int x2 =calculator2.Sum(1, 2);
int x3 =calculator3.Sum(1, 2, 3);
int x4 =calculator4.Sum(1, 2, 3, 4);
int x5 =calculator2.multiply(1 * 2 * 3);
int x6 =calculator3.multiply(2 * 3 * 4);

Console.WriteLine(calculator.GetLog());
Console.WriteLine(calculator2.GetLog());
Console.WriteLine(calculator3.GetLog());
Console.WriteLine(calculator4.GetLog());

