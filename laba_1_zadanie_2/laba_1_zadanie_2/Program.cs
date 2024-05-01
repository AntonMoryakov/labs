using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров компонентов
        IDateTimePrinter europeanPrinter = new EuropeanDateTimePrinter();
        IDateTimePrinter americanPrinter = new AmericanDateTimePrinter();

        // Применение декораторов
        IDateTimePrinter decoratedEuropeanPrinter = new SymbolDecorator(europeanPrinter, " <Euro Style> ");
        IDateTimePrinter decoratedAmericanPrinter = new SymbolDecorator(americanPrinter, " <US Style> ");

        // Вывод результатов применения декораторов
        Console.WriteLine("European Style: " + decoratedEuropeanPrinter.GetFormattedDateTime());
        Console.WriteLine("American Style: " + decoratedAmericanPrinter.GetFormattedDateTime());

        // Вывод оригинала
        Console.WriteLine("European Style: " + europeanPrinter.GetFormattedDateTime());
        Console.WriteLine("American Style: " + americanPrinter.GetFormattedDateTime());
    }
}
