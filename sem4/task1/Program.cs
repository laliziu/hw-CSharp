// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



int GetNumber2(string text)
{
    Console.Write(text);
    int numberB = int.Parse(Console.ReadLine());
    return numberB;
}

int GetNumber(string text)
{
    Console.Write(text);
    int numberA = int.Parse(Console.ReadLine());
    return numberA;
}


int PowerNum(int numberA, int numberB)
{
int result = numberA;
for (int count = 2; count <= numberB; count++)
    {
        result = result * numberA;
    }
    return result;
}


int numberA = GetNumber("enter the number A: ");
int numberB = GetNumber2(" enter the number B: ");
int result = PowerNum (numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");