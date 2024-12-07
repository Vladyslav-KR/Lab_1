using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Викликаємо метод для налаштування кодування
            BaseConsole.Initialize();

            // Введення даних про користувача
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = int.Parse(Console.ReadLine());

            // Створення екземпляра класу User
            User user = new User(login, firstName, lastName, age);

            // Виведення інформації про користувача
            user.DisplayUserInfo();
        }
    }
}
