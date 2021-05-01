using System;

namespace Working_with_Unix_Timestamps
{
    class Program
    {
        static void Main(string[] args)
        {
            long timestamp = 1617282420;

            DateTimeOffset date =
                DateTimeOffset.FromUnixTimeSeconds(timestamp);
            
            DateTime unixEpoch
                = new DateTime(1970, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            DateTime dateFromTimestamp
                = unixEpoch.AddSeconds(timestamp);

            long dateAsTimestamp =
                new DateTimeOffset(dateFromTimestamp).ToUnixTimeSeconds();

            Console.WriteLine(timestamp);
            Console.WriteLine(dateAsTimestamp);
        }
    }
}
 