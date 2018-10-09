using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Operation
    {
        public static void OutInfoCulture(CultureInfo x, CultureInfo y)
        {
            Print(string.Empty, GetCultureName(x), GetCultureName(y));
            Print("Number separator", x.NumberFormat.NumberDecimalSeparator, y.NumberFormat.NumberDecimalSeparator);
            Print("Number group separator", x.NumberFormat.NumberGroupSeparator, y.NumberFormat.NumberGroupSeparator);
            Print("Currency symbol", x.NumberFormat.CurrencySymbol, y.NumberFormat.CurrencySymbol);
            Print("Data format", x.DateTimeFormat.ShortDatePattern, y.DateTimeFormat.ShortDatePattern);
            Print("AM Designator", x.DateTimeFormat.AMDesignator, y.DateTimeFormat.AMDesignator);
            Print("PM Designator", x.DateTimeFormat.PMDesignator, y.DateTimeFormat.PMDesignator);
            Print("Time", x.DateTimeFormat.ShortTimePattern, y.DateTimeFormat.ShortTimePattern);
            Print("First Day Of Week", x.DateTimeFormat.FirstDayOfWeek.ToString(), y.DateTimeFormat.FirstDayOfWeek.ToString());
        }

        private static string GetCultureName(CultureInfo culture)
        {
            const string DefaultName = "invariant";
            return string.IsNullOrEmpty(culture.Name) ? DefaultName : culture.Name;
        }

        private static void Print(string message, string cultureName1, string cultureName2)
        {
            const string PrintFormat = "{0,-25}{1,15}{2,15}";
            Console.WriteLine(PrintFormat, message, cultureName1, cultureName2);
        }
    }
}
