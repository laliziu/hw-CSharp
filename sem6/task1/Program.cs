// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int MoreThanZero(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) count++;
    }
    return count;
}


int[] GetArray(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, (to + 1));
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int size = GetSize("Amount of numbers: ");
int[] array = GetArray(size, -100, 999);
int count = MoreThanZero(array);
Console.Write(String.Join(", ", array));
Console.WriteLine($" -> {count}");