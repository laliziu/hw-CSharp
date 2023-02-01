// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


class Program
{
    static void Main(string[] args)
    {
        int num, rem, reversedNum = 0, temp;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rem = num % 10;
            num = num / 10;
            reversedNum = reversedNum * 10 + rem;
        }
        Console.WriteLine($"The Reversed Number is: {reversedNum}");
        if (temp == reversedNum)
        {
            Console.WriteLine("Number is Palindrome");
        }
        else
        {
            Console.WriteLine("Number is not a palindrome");
        }
        Console.ReadLine();
    }
}