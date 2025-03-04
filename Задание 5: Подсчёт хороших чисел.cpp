using System;

class Program
{
    // метод для проверки, является ли число "хорошим"
    static bool IsGoodNumber(int number)
    {
        int sum = 0;
        int temp = number;
        while (temp > 0)
        {
            sum += temp % 10; // суммируем цифры числа
            temp /= 10;
        }
        return sum != 0 && number % sum == 0; // проверяем, делится ли число на сумму цифр
    }

    static void Main()
    {
        DateTime start = DateTime.Now; // запоминаем время начала
        int count = 0;
        
        for (int i = 1; i <= 1000000000; i++) // это лучше уменьшить
            if (IsGoodNumber(i)) count++; // считаем "хорошие" числа
        
        DateTime end = DateTime.Now; //  время окончания
        Console.WriteLine($"найдено: {count} чисел, время: {(end - start).TotalSeconds} сек");
    }
}
