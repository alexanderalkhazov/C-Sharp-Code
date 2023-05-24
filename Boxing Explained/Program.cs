using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Explained
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // BOXING is basically converting value type to reference type.

            // here is an example.

            // here i declare value type 
            int number = 10;

            //here i convert number to object and send it to heap.
            object obj = number;

            // this is BOXING now i created new object of int in the heap



            // now we do UNBOXIMG 

            int a = (int)obj;

        }
    }
}
