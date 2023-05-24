using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// pointers
// are defined as a variable that contains the memory address of another variable.
// pointers should only be used when there is an unsafe statement.
// those statements are not by control of the garbage collector.




namespace Pointers
{
    class Demo
    {
        public void Method()
        {
            unsafe
            {
                int a = 40;
                int b = 20;
                int* ptr1 = &a;
                int* ptr2 = &b;
                Console.WriteLine(*ptr1);    // displaying the value
                Console.WriteLine(*ptr2);    // displaying the value
                Console.WriteLine((int)ptr1); // displaying the address
                Console.WriteLine((int)ptr2); // displaying the address
            }
        }
    }
    class Example
    {
        // main method
        public static void Main()
		{
			unsafe
			{
				Demo b = new Demo();
				int* pointer = (int*)&b;
				Console.WriteLine(*pointer);
				Console.ReadLine();
			}    
        }
    }
}