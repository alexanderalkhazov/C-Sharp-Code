using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// Exceptions in C# are for handling runtime errors . we perform exception handling so the normal flow of our app wont stop.
// in C# exception is an event or object that is thrown at runtime . 




namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string operation = null;
                double result;
                // exception showen bwlow:

                // imagine this is an app with alot of functionality and we try to do a simple thing like divide by zero whice is not ok.


                Console.WriteLine("enter your first number !");
                double first = double.Parse(Console.ReadLine());
                Console.WriteLine("Give me second number");
                double second = double.Parse(Console.ReadLine());

                // ok now lets ask for operation ! 
                Console.WriteLine("Give me only those ones \n+\n-\n/\n*");
                operation = Console.ReadLine();


                if (operation == "+")
                {
                    result = first + second;
                    MessageBox.Show(result.ToString());
                }
                if (operation == "-")
                {
                    result = first - second;
                    MessageBox.Show(result.ToString());
                }
                if (operation == "*")
                {
                    result = first * second;
                    MessageBox.Show(result.ToString());
                }

                if (operation == "/")
                {
                    try
                    {
                        result = first / second;
                    }  
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.ReadLine();
            }



        }
    }
}
