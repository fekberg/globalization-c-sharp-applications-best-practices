using System;

namespace Searching_for_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Can we find this character: ̊a";

            int index = data.IndexOf("\u00e5", 
                StringComparison.InvariantCulture); // å

            Console.WriteLine(index);
        }
    }
}
