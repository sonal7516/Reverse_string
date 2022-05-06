using System;
using System.Linq;

namespace Reverse_string
{
    class Program
    {
        public static void Reverse_byLinq(string str)
        {
            string reverse_str = string.Join("", str.Split()
                 .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(reverse_str);
            Console.ReadLine();
        }

        public static void Reverse_byLoop()
        {
            Console.WriteLine("Enter the string");
           string str =  Console.ReadLine();
            string reverse = string.Empty;
            int len = str.Length-1;
            while (len >= 0)
            {
                reverse = reverse + str[len];
                len--;
            }
            Console.WriteLine("Reverse string:{0}",reverse);

        }
        static void Main(string[] args)
        {

            // Reverse_byLinq("sonal");
            Reverse_byLoop();
            
        }
    }
}
