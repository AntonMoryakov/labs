using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_zadanie_2
{
    // Базовый класс для компонентов
    class BaseDateTimePrinter : IDateTimePrinter
    {
        public virtual string GetFormattedDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
