using System;

namespace Introducing_DateTimeOffset
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset now = DateTimeOffset.Now;

            DateTimeOffset otherDate = now.ToOffset(TimeSpan.FromHours(1));

            DateTimeOffset utcDate = otherDate.ToUniversalTime();


            // Convert this to the CORRECT local time!

            DateTime date = new DateTime(2020, 01, 01, 13, 30, 0,
                                         DateTimeKind.Utc);

            DateTime date2 = new DateTime(2020, 04, 01, 13, 30, 0,
                                         DateTimeKind.Utc);

            var localDate = TimeZoneInfo.ConvertTimeFromUtc(date,
                TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));
            
            var localDate2 = TimeZoneInfo.ConvertTimeFromUtc(date2,
              TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));


        }
    }
}
