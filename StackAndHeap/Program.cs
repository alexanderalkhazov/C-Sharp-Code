using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // value type 
            // on the stack a value is stored.
            ValueExample valueExample = new ValueExample();
            valueExample.StructValue = 10;


            // reference type 
            // in stack a pointer is created to an object on the heap
            ReferenceExamle referenceExamle = new ReferenceExamle();
            // it will change the value because we pass in function an address to object 
            referenceExamle.ClassValue = 10;
            ChangeValueForClass(referenceExamle);
            Console.WriteLine(referenceExamle.ClassValue);


            // here we will do the same but only with struct .
            // it will not change value unless we will use ref key word of course.
            valueExample.StructValue = 10;
            ChangeValueForStruct(ref valueExample);
            Console.WriteLine(valueExample.StructValue);

            Console.ReadLine();
        }


        static void ChangeValueForClass(ReferenceExamle r)
        {
            r.ClassValue = 2500;
        }



        static void ChangeValueForStruct(ref ValueExample v)
        {
            v.StructValue = 20000;
        }

    }



    class ReferenceExamle
    {
        public int ClassValue { get; set; }

    }
    struct ValueExample
    {
        public int StructValue { get; set; }
    }


}
