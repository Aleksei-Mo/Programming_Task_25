// Задача 25. Напишите цикл, который принимает на вход два числа А и В и возводит А в натуральную степень В.
Console.Clear();
Console.WriteLine("This programm implements raising your number to the power (A^B).");
Console.Write("Enter your number A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your natural number B (the power): ");
int numberB = Convert.ToInt32(Console.ReadLine());
double result = Power(numberA,numberB);
Console.WriteLine($"Raising {numberA} to the power {numberB} is equal to {result}.");


double Power(double basis, int power)
{
 double powerResult=1;

 for(int index=1; index<=power; index++)
   {
    powerResult=powerResult * basis;
   }
   
 return powerResult;
}