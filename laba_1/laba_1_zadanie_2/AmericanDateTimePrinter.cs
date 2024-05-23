using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_zadanie_2
{
    class AmericanDateTimePrinter : BaseDateTimePrinter
    {
        public override string GetFormattedDateTime()
        {
            CultureInfo usCulture = new CultureInfo("en-US");
            return DateTime.Now.ToString(usCulture);
        }
    }
}
