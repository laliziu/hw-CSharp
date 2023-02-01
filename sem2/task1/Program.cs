// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 1000);
Console.WriteLine($"Select number: {num}");
int num2 = num / 10;
int num3 = num2 % 10;
Console.WriteLine($"The second digit of this number is: {num3} ");


