using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_VS_AS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. is keyword
            // the is keyword is used to check if two types are the same type
            //

            // example
            object str = "Shiv";
            if (str is string)
            {
                Console.WriteLine(true);
            }


            // 2. As keyword 
            // the as keyword check if we can convert to another object and use it.


            // example :
            object str2 = "shiv";
            string x = str2 as string;


        }
    }
}
