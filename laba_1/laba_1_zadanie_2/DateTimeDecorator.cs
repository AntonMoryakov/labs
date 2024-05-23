using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_zadanie_2
{
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
}
