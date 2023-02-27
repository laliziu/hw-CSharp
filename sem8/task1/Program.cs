//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int index = 0; index < array.GetLength(1); index++)
        {
            int maxIndex = index;
            for (int j = index; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, maxIndex])
                {
                    maxIndex = j;
                }
            }
            int temp = array[i, index];
            array[i, index] = array[i, maxIndex];
            array[i, maxIndex] = temp;
        }
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int lines, int columns, int min, int max)
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    return int.Parse(size);
}

int m = GetSize("Enter the number of lines: ");
int n = GetSize("Enter the number of columns: ");
int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);
FromMaxToMin(array);
PrintArray(array);
