// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("enter 1st number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("enter 3rd number: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (num1 > max) max = num1;

if (num2 > max) max = num2;

if (num3 > max) max = num3;

Console.Write("max = " + max);
