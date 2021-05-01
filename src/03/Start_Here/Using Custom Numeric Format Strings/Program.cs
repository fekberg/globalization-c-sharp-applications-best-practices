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
        }
    }
}
