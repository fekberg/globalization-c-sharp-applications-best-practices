using System;
using System.Globalization;
using System.Text;

namespace Using_Custom_Numeric_Format_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var culture = CultureInfo.CreateSpecificCulture("en-US");
            culture.NumberFormat.NumberGroupSeparator = " ";

            decimal number = 1_000.50m;

            string numberAsString =
                number.ToString("#,#.#", culture);

            string numberAsStringSwedish =
                number.ToString("#,#.#", new CultureInfo("sv-SE"));

            Console.WriteLine(numberAsString);
            Console.WriteLine(numberAsStringSwedish);
        }
    }
}
