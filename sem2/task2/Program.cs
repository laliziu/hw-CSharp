// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write(" enter the number: ");
int num = int.Parse(Console.ReadLine());

float digit = 0;
if (num < 100) Console.WriteLine($"{num} is not a 3 digit number");
else
{
    digit = (num - num % (MathF.Pow(10, (num.ToString().Length - 3)))) / MathF.Pow(10, (num.ToString().Length - 3)) % 10;
    Console.WriteLine($" 3rd number of the {num} is: {digit}");
}

