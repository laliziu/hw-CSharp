// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("enter 1st number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine("max = " + max + "  min = " + min);
