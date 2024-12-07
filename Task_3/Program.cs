using System;

namespace Task_3
{

    class Program
    {
        static void Main(string[] args)
        {
            // Викликаємо налаштування для кодування
            BaseConsole.Initialize();

            // Введення даних
            Console.Write("Введіть прізвище співробітника: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть ім'я співробітника: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть посаду (junior, middle, senior): ");
            string position = Console.ReadLine();

            Console.Write("Введіть стаж роботи (роки): ");
            int experience = int.Parse(Console.ReadLine());

            // Створення екземпляра класу Employee
            Employee employee = new Employee(lastName, firstName)
            {
                Position = position,
                Experience = experience
            };

            // Розрахунок окладу та податку
            employee.CalculateSalary();

            // Виведення інформації
            employee.DisplayInfo();
        }
    }
}
