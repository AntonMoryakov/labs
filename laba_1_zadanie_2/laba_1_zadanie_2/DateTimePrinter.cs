using System;
using System.Globalization;
using System.Text;

// Интерфейс для компонентов и декораторов
interface IDateTimePrinter
{
    string GetFormattedDateTime();
}

// Базовый класс для компонентов
class BaseDateTimePrinter : IDateTimePrinter
{
    public virtual string GetFormattedDateTime()
    {
        return DateTime.Now.ToString();
    }
}

// Класс для вывода даты и времени в европейском стиле
class EuropeanDateTimePrinter : BaseDateTimePrinter
{
    public override string GetFormattedDateTime()
    {
        CultureInfo euCulture = new CultureInfo("fr-FR");
        return DateTime.Now.ToString(euCulture);
    }
}

// Класс для вывода даты и времени в американском стиле
class AmericanDateTimePrinter : BaseDateTimePrinter
{
    public override string GetFormattedDateTime()
    {
        CultureInfo usCulture = new CultureInfo("en-US");
        return DateTime.Now.ToString(usCulture);
    }
}

// Базовый класс для декораторов
abstract class DateTimeDecorator : IDateTimePrinter
{
    protected IDateTimePrinter dateTimePrinter;

    public DateTimeDecorator(IDateTimePrinter printer)
    {
        dateTimePrinter = printer;
    }

    public virtual string GetFormattedDateTime()
    {
        return dateTimePrinter.GetFormattedDateTime();
    }
}

// Декоратор для добавления символов к дате и времени
class SymbolDecorator : DateTimeDecorator
{
    private string symbol;

    public SymbolDecorator(IDateTimePrinter printer, string symbol) : base(printer)
    {
        this.symbol = symbol;
    }

    public override string GetFormattedDateTime()
    {
        string baseDateTime = dateTimePrinter.GetFormattedDateTime();
        StringBuilder sb = new StringBuilder(baseDateTime);
        sb.Append(symbol);
        return sb.ToString();
    }
}