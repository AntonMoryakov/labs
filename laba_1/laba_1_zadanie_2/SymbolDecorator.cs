using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_zadanie_2
{
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
}
