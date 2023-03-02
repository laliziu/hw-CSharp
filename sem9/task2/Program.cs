// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

int[] GetSum(int from, int to, int[] numbers = null, int i = 0)
{
    if (numbers == null) 
    {
        int len = Math.Abs(from - to);
        numbers = new int[len + 1];
    }
    numbers[i++] = from;
    if (from > to) from--; else from++;
    if (numbers != null && i == numbers.Length) return numbers;
    return GetSum(from, to, numbers, i);
}

void PrintArray(int[] array, int i = 0)
{
    if (i == 0) Console.Write("[");
    if (array.Length < 1)
    {
        Console.WriteLine("]");
        return;
    }
    if (i == array.Length - 1)
    {
        Console.WriteLine("{0}]", array[i]);
        return;
    }
    Console.Write("{0}, ", array[i++]);
    PrintArray(array, i);
}

int PromptNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int number = PromptNumber("Input number N: ");

int[] sum = GetSum(number, 1);
PrintArray(sum);