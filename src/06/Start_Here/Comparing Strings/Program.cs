using System;
using System.Globalization;

namespace Comparing_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first    = "\u00e5";       // å
            string second   = "\u0061\u030a"; // a ̊  

            bool result = string.Equals(first, second,
                StringComparison.InvariantCulture);

            int sortOrderOrdinal =
                string.Compare(first, second, StringComparison.OrdinalIgnoreCase);

            int sortOrderInvariant =
                string.Compare(first, second, StringComparison.InvariantCulture);

            Console.WriteLine(sortOrderOrdinal);
            Console.WriteLine(sortOrderInvariant);

            int sortOrderCurrentCulture =
                CultureInfo.CurrentCulture.CompareInfo.Compare(first, second);

            Console.WriteLine(sortOrderCurrentCulture);
        }
    }
}
