// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int DifMaxMin(int[] array)
{
    int result = 0;
    int min = array[0];
    int max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
        if (array[index] > max)
        {
            max = array[index];
        }
    }
    result = max - min;
    return result;
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

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(min, max + 1);
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
int[] array = GetArray(size, -20, 10);
PrintArray(array);
int result = DifMaxMin(array);
Console.Write($" -> {result}");