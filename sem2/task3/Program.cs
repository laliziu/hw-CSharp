// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number from 1 to 7: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("This day is a weekend");
}
else if (number >= 1 || number < 6)
{
    Console.Write(" - This day is a weekday.");
}
