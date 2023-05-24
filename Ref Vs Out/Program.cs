using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Vs_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            Console.WriteLine("before change");
            Console.WriteLine(a);

            Console.WriteLine("after ref");
            RefExmp(ref a);
            Console.WriteLine(a);


            int b;
            Console.WriteLine("after out");
            OutExmp(out b);
            Console.WriteLine(b);


            Console.ReadLine();
        }



        static void RefExmp(ref int a)
        {
            a = 200;
        }


        static void OutExmp(out int b)
        {
            b = 300;
        }



    }
}
