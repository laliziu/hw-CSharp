// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// пусть б1 = 1, к1=2, б2=3, к2=4
// K1x+B1=K2X+B2   2x+1=4x+3  y=2*-1+1=-1
// K1x-K2X=B1+B2   2x-4x=3-1
//                -2x=2 x=-1   

string PointCrossed(int B1, int K1, int B2, int K2)
{
    double x = (B2 - B1) / (K1 - K2);
    double y = (K1 * (B2 - B1)) / (K1 - K2) + B1;
    Console.WriteLine($"{x},{y}");
    return $"({x}; {y})";
}


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numberB1 = GetNum("Enter number B1: ");
int numberK1 = GetNum("Enter number K1: ");
int numberB2 = GetNum("Enter number B2: ");
int numberK2 = GetNum("Enter number K2: ");
Console.Write($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2} -> ");
PointCrossed(numberB1, numberK1, numberB2, numberK2);