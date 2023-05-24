using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// in C# string is an object of system.string class that represent a sequeance of characters.
// 

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Rony";
            String lastName = "bob";  // this is the same thing as saying string / String.

            // some example 

            string s1 = "hello";
            char[] ch = { 'h', 'e', 'l', 'o' };
            string result = new string(ch);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
