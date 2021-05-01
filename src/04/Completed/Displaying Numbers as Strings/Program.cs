using System;
using System.Globalization;
using System.Text;

namespace Displaying_Numbers_as_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            
            decimal number = 1_000_000.50m;

            string numberAsString = number.ToString("C0", culture);

            string numberAsSwedishKronors =
                (number * 8.70m)
                .ToString("C", CultureInfo.CreateSpecificCulture("sv-SE"));

            Console.WriteLine(numberAsString);
            Console.WriteLine(numberAsSwedishKronors);
        }
    }
}
