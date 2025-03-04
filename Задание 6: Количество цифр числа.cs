using System;

class Program
{
    // метод через logaрифмик
    static int CountDigits(int number)
    {
        return number == 0 ? 1 : (int)Math.Log10(Math.Abs(number)) + 1; // используем логарифм для подсчета
    }

    static void Main()
    {
        int number = 87346;
        Console.WriteLine($"количество цифр в числе {number}: {CountDigits(number)}");
    }
}
