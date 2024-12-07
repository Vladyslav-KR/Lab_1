using System;

namespace Task_4
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfRegistration { get; }

        // Конструктор для ініціалізації даних користувача
        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DateOfRegistration = DateTime.Now; // ініціалізуємо дату заповнення анкети
        }

        // Метод для виведення інформації про користувача
        public void DisplayUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine($"Логін: {Login}");
            Console.WriteLine($"Ім'я: {FirstName}");
            Console.WriteLine($"Прізвище: {LastName}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Дата заповнення анкети: {DateOfRegistration}");
        }
    }
}