// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetSum(int number)
{
    int result = 0;
    int temp = number;
    for (int i = 0; i < number.ToString().Length; i++)
    {
        result = result + temp % 10;
        temp = temp / 10;
    }
    return result;
}

int number = GetNumber("enter the number: ");
int result = GetSum(number);
Console.WriteLine($"{number} -> {result}");
