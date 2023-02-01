// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void distance(double x, double y, double z, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((y2 - y), 2) + Math.Pow((z2 - z), 2));
    Console.Write(distance);
}


int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


//вводим данные
double x = GetNum("enter the number: ");
double y = GetNum("enter the number: ");
double z = GetNum("enter the number: ");
double x2 = GetNum("enter the number: ");
double y2 = GetNum("enter the number: ");
double z2 = GetNum("enter the number: ");
Console.Write(" distance is: ");

distance(x, y, z, x2, y2, z2);




