// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int CheckElementArray(int[,,] array, int number)
{
    int count = 0;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j, k] == number)
                {
                    count++;
                }
            }
        }
    }
    return count;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine();
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,3}" + $"({i},{j},{k})", array[i, j, k]);
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] GetArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    int count = 0;
    for (int k = 0; k < depth; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
                count = CheckElementArray(array, array[i, j, k]);
                while (count > 1)
                {
                    array[i, j, k] = new Random().Next(min, max + 1);
                    count = CheckElementArray(array, array[i, j, k]);
                }
            }
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    return int.Parse(Console.ReadLine());
}

int size = GetSize("Enter the number of lines,columns,depth");
int[,,] array = GetArray(size, size, size, 10, 99);
PrintArray(array);