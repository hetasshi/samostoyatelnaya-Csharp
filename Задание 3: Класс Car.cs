using System;

class Car
{
    public string Brand { get; } // марка 
    public int Year { get; } // год 
    public int Mileage { get; private set; } // пробег

    // конструктор для создания автомобиля
    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
        Mileage = 0; // пробег 0 как вы и сказали
    }

    // метод для увеличения пробега
    public void Drive(int km)
    {
        if (km > 0) // проверка на пробег положительный
            Mileage += km;
    }

    // метод для вывода инфо об авто
    public void DisplayInfo()
    {
        Console.WriteLine($"марка: {Brand}, год: {Year}, пробег: {Mileage} км");
    }

    // деструктор (вызывается при уничтожении объекта)
    ~Car()
    {
        Console.WriteLine($"объект {Brand} уничтожен");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2020); // создаем автомобиль
        car.Drive(150); // увеличиваем пробег
        car.DisplayInfo(); // выводим информацию
    }
}
