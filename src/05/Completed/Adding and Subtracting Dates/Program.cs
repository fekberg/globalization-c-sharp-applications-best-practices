using System;

namespace Adding_and_Subtracting_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset date
                = new DateTimeOffset(2021, 01, 29, 
                                     23, 59, 00, TimeSpan.Zero);

            DateTimeOffset newDate = date.AddMonths(1);

            DateTimeOffset now = DateTimeOffset.Now
                .ToOffset(TimeSpan.FromHours(1));

            DateTimeOffset otherDate = now.ToOffset(TimeSpan.FromHours(3));
            otherDate = otherDate.AddMinutes(1);

            TimeSpan difference = otherDate - now;
        }
    }
}
