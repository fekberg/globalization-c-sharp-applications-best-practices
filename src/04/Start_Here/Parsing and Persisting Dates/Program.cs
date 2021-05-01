using System;
using System.Globalization;

namespace Parsing_and_Persisting_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset date = new DateTimeOffset(
                    2021, 05, 10, 
                    18, 30, 59, 
                    TimeSpan.FromHours(8));
        }
    }
}
