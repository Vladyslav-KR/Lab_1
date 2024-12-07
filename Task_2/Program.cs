using System;


class Program
{
    static void Main()
    {
        // Виведення інструкцій для користувача
        Console.WriteLine("Виберіть тип конвертації:");
        Console.WriteLine("1. З гривні в іноземну валюту");
        Console.WriteLine("2. З іноземної валюти в гривню");
        int choice = int.Parse(Console.ReadLine());

        // Введення курсів валют
        Console.WriteLine("\nВведіть курси валют щодо гривні:");
        Console.Write("Курс USD: ");
        double usdRate = double.Parse(Console.ReadLine());

        Console.Write("Курс EUR: ");
        double eurRate = double.Parse(Console.ReadLine());

        Console.Write("Курс PLN: ");
        double plnRate = double.Parse(Console.ReadLine());

        // Створення екземпляра класу Converter
        Converter converter = new Converter(usdRate, eurRate, plnRate);

        // Обробка вибору користувача
        if (choice == 1)
        {
            // Конвертація з гривні в іноземні валюти
            Console.WriteLine("\nВведіть суму в гривнях для конвертації:");
            double amountInUah = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВиберіть валюту для конвертації:");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. PLN");
            int currencyChoice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (currencyChoice)
            {
                case 1:
                    result = converter.ConvertFromUAHToUSD(amountInUah);
                    break;
                case 2:
                    result = converter.ConvertFromUAHToEUR(amountInUah);
                    break;
                case 3:
                    result = converter.ConvertFromUAHToPLN(amountInUah);
                    break;
                default:
                    Console.WriteLine("Невірний вибір валюти.");
                    break;
            }

            Console.WriteLine($"Конвертовано: {result} вказаної валюти");
        }
        else if (choice == 2)
        {
            // Конвертація з іноземних валют в гривню
            Console.WriteLine("\nВведіть суму в обраній валюті для конвертації в гривню:");
            double amountInForeignCurrency = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВиберіть валюту для конвертації в гривню:");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. PLN");
            int currencyChoice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (currencyChoice)
            {
                case 1:
                    result = converter.ConvertFromUSDToUAH(amountInForeignCurrency);
                    break;
                case 2:
                    result = converter.ConvertFromEURToUAH(amountInForeignCurrency);
                    break;
                case 3:
                    result = converter.ConvertFromPLNToUAH(amountInForeignCurrency);
                    break;
                default:
                    Console.WriteLine("Невірний вибір валюти.");
                    break;
            }

            Console.WriteLine($"Конвертовано: {result} гривень");
        }
        else
        {
            Console.WriteLine("Невірний вибір типу конвертації.");
        }
    }
}
