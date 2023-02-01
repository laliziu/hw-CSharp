// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int EvenCount(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int[] GetArray(int size, int start, int finish)
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(start, finish + 1);
    }
    return arr;
}

int GetSize(string text)
{
    Console.Write(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int size = GetSize("enter array size: ");
int[] array = GetArray(size, 100, 999);
PrintArray(array);
int count = EvenCount(array);
Console.Write($" -> {count}");
