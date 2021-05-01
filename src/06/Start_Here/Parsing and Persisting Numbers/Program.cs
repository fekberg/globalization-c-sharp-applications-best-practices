using System;
using System.Globalization;
using System.Text;

namespace Parsing_and_Persisting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // 1_000_000.5.ToString("#,#.#", new CultureInfo("sv-SE"));
            // 1_000_000.5.ToString("C", new CultureInfo("sv-SE"));

            var numberAsString = "1 000 000,5 kr";
            
            if(decimal.TryParse(numberAsString, 
                NumberStyles.Currency,
                new CultureInfo("sv-SE"),
                out decimal number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
