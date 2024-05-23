using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_zadanie_2
{
    // Класс для вывода даты и времени в европейском стиле
    class EuropeanDateTimePrinter : BaseDateTimePrinter
    {
        public override string GetFormattedDateTime()
        {
            CultureInfo euCulture = new CultureInfo("fr-FR");
            return DateTime.Now.ToString(euCulture);
        }
    }
}
