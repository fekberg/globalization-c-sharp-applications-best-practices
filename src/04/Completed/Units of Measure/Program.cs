using System;
using System.Globalization;
namespace Units_of_Measure
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture 
                = CultureInfo.CreateSpecificCulture("sv-SE");

            RegionInfo region = new RegionInfo(culture.LCID);

            decimal distance = 10m;

            if (region.IsMetric)
            {
                Console.WriteLine(distance);
            }
            else
            {
                decimal distanceInFeet = distance * 3.281m;
                Console.WriteLine(distanceInFeet);
            }
        }
    }
} 
