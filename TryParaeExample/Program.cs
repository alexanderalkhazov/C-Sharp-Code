using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParaeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter A Number");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine($"Its a number \nnumber: {a}");
                }
                else
                {
                    Console.WriteLine("Not  number");
                }
                Console.ReadLine();
            }
        }
    }
}
