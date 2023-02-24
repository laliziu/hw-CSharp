// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double Sum(int[,] array, int j)
{
    double sum = 0.0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    return sum;
}

void Average(int[,] array)
{
    Console.WriteLine();
    Console.Write("Average of the columns: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == (array.GetLength(1) - 1)) Console.Write($"{Math.Round(Sum(array, j) / array.GetLength(0), 1)}.");
        else Console.Write($"{Math.Round(Sum(array, j) / array.GetLength(0), 1)}; ");
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + $"\t");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int lines = GetSize("Enter the number of lines: ");
int columns = GetSize("Enter the number of columns: ");
int[,] array = GetArray(lines, columns, 0, 10);
PrintArray(array);
Average(array);
