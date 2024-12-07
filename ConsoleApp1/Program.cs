using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Ініціалізація для коректного виведення кирилиці в консолі
        Console.OutputEncoding = Encoding.UTF8;

        // Створення екземпляра класу Address
        Address address = new Address();

        // Введення даних про адресу з консолі
        Console.WriteLine("Введіть поштову адресу:");

        Console.Write("Індекс: ");
        address.Index = Console.ReadLine();

        Console.Write("Країна: ");
        address.Country = Console.ReadLine();

        Console.Write("Місто: ");
        address.City = Console.ReadLine();

        Console.Write("Вулиця: ");
        address.Street = Console.ReadLine();

        Console.Write("Будинок: ");
        address.House = Console.ReadLine();

        Console.Write("Квартира: ");
        address.Apartment = Console.ReadLine();

        // Виведення інформації про адресу
        Console.WriteLine("\nВаша адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");
    }
}