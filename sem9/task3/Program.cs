// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ackermann(m-1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int GetNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int number1 = GetNumber("Enther the first num: ");
int number2 = GetNumber("Enter the second num: - ");
Console.WriteLine($"m = {number1}, n = {number2} -> A(m,n) = {Ackermann(number1, number2)}");