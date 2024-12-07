using System;

class Employee
{
    // Поля для прізвища, імені, посади та стажу
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }

    // Оклад і податковий збір
    public double Salary { get; set; }
    public double Tax { get; set; }

    // Конструктор класу
    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    // Метод для розрахунку окладу
    public void CalculateSalary()
    {
        switch (Position.ToLower())
        {
            case "junior":
                Salary = 10000;
                break;
            case "middle":
                Salary = 20000;
                break;
            case "senior":
                Salary = 30000;
                break;
            default:
                Salary = 0;
                break;
        }

        // Збільшення окладу в залежності від стажу
        if (Experience >= 5)
            Salary += 5000;
        else if (Experience >= 2)
            Salary += 2000;

        // Розрахунок податкового збору
        Tax = Salary * 0.18;
    }

    // Метод для виведення інформації
    public void DisplayInfo()
    {
        Console.WriteLine($"Співробітник: {FirstName} {LastName}");
        Console.WriteLine($"Посада: {Position}");
        Console.WriteLine($"Оклад: {Salary} грн");
        Console.WriteLine($"Податковий збір: {Tax} грн");
    }
}