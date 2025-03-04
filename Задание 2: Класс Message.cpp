using System;

static class Message
{
// три метода основных по заданию ->

    // метод для вывода слов, длина которых не превышает n
    public static void PrintWordsUpToLength(string text, int n)
    {
        string[] words = text.Split(' '); // разбиваем текст на слова
        foreach (var word in words)
            if (word.Length <= n) // если длина слова подходит
                Console.WriteLine(word);
    }

    // метод для удаления слов, которые заканчиваются на заданный символ
    public static string RemoveWordsEndingWith(string text, char c)
    {
        string[] words = text.Split(' '); // разбиваем текст на слова
        string result = "";
        foreach (var word in words)
            if (!word.EndsWith(c.ToString())) // если слово не заканчивается на символ
                result += word + " "; // добавляем его в результат
        return result.Trim(); // убираем лишние пробелы в конце
    }

    // метод для поиска самого длинного слова в тексте
    public static string FindLongestWord(string text)
    {
        string[] words = text.Split(' '); // разбиваем текст на слова
        string longest = "";
        foreach (var word in words)
            if (word.Length > longest.Length) // если текущее слово длиннее
                longest = word; // обновляем самое длинное слово
        return longest;
    }
}

class Program
{
    static void Main()
    {
        string text = "hello world this is a test message";
        
        Console.WriteLine("слова не длиннее 4:");
        Message.PrintWordsUpToLength(text, 4); // выводим слова длиной до 4 символов
        
        Console.WriteLine("\nудаляем слова, оканчивающиеся на 's':");
        string newText = Message.RemoveWordsEndingWith(text, 's'); // удаляем слова на 's'
        Console.WriteLine(newText);
        
        Console.WriteLine("\nсамое длинное слово:");
        Console.WriteLine(Message.FindLongestWord(text)); // находим самое длинное слово
    }
}
