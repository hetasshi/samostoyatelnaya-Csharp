class Student
{
    private string name; // имя студента
    private int age; // возраст студента
    private int grade; // оценка от 1 до 5

    // конструктор снова
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        grade = 1; // по дефолту оценка 1
    }

    // метод для изменения оценки, только от 1 до 5
    public void SetGrade(int value)
    {
        if (value >= 1 && value <= 5) // проверяем, что оценка в допустимом диапазоне
            grade = value;
    }

    // метод для вывода 
    public void DisplayInfo()
    {
        Console.WriteLine($"имя: {name}, возраст: {age}, оценка: {grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("аня", 20); // создаем студента
        student.SetGrade(4); // устанавливаем оценку
        student.DisplayInfo(); // выводим информацию))
    }
}
