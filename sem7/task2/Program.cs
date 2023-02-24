// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет 

int FindTheNumber(int[,] array, int number)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"{number} -> is in the array");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine($"{number} is not in the array ");
    return count;
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

int[,] GenerateArray(int lines, int colums, int min, int max)
{
    int[,] result = new int[lines, colums];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
int GetSize(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int m = GetSize("Enter the number of lines: ");
int n = GetSize("Enter the number of colums: ");
int[,] array = GenerateArray(m, n, 0, 20);
PrintArray(array);
FindTheNumber(array, 12);


