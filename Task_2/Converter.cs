using System;

class Converter
{
    // Поля для курсів валют
    public double UsdRate { get; set; }
    public double EurRate { get; set; }
    public double PlnRate { get; set; }

    // Конструктор, який ініціалізує курси валют
    public Converter(double usd, double eur, double pln)
    {
        UsdRate = usd;
        EurRate = eur;
        PlnRate = pln;
    }

    // Конвертація з гривні в USD
    public double ConvertFromUAHToUSD(double amount)
    {
        return amount / UsdRate;
    }

    // Конвертація з гривні в EUR
    public double ConvertFromUAHToEUR(double amount)
    {
        return amount / EurRate;
    }

    // Конвертація з гривні в PLN
    public double ConvertFromUAHToPLN(double amount)
    {
        return amount / PlnRate;
    }

    // Конвертація з USD в гривню
    public double ConvertFromUSDToUAH(double amount)
    {
        return amount * UsdRate;
    }

    // Конвертація з EUR в гривню
    public double ConvertFromEURToUAH(double amount)
    {
        return amount * EurRate;
    }

    // Конвертація з PLN в гривню
    public double ConvertFromPLNToUAH(double amount)
    {
        return amount * PlnRate;
    }
}
