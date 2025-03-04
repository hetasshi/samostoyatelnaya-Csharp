using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // шаблон для проверки - первая буква, затем буквы или цифры от 2 до 10 символов
        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

        Console.Write("введите логин: ");
        string login = Console.ReadLine();

        // ну тут проверка
        bool isValid = Regex.IsMatch(login, pattern);
        Console.WriteLine(isValid ? "корректно" : "некорректно");
    }
}
