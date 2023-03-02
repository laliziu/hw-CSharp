// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N от большего к меньшему. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int number)
{
    if (number == 1) Console.Write("1");
    else
    {
        Console.Write("{0}, ", number); PrintNumbers(number - 1);
    }
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int number = GetNum("Enter the number:");
PrintNumbers(number);