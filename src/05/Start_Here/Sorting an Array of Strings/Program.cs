using System;
using System.Globalization;

namespace Sorting_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {  "Örjan", "Zoe", "filip",
                                "Olof", "chris", "Chloë", "Mila",
                                "John", "Åsa", "Anna", "Sofie", "Fèlip" };

            CultureInfo.CurrentCulture = new CultureInfo("en-US");



            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
