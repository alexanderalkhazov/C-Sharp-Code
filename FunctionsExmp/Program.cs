using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExmp
{
	internal class CallFunctions
	{
		static void Main(string[] args)
		{
			int result = Functions.CalculateMe(1,20);  // calculates my numbers that i pass to it 
			Console.WriteLine("print me the result of function calculate me , result :" + result);
			Functions.PrintMeSomething("hey there"); // prints me something that i pass to  it
			Person p = Functions.ReturnPerson(); // return me new person .
			Console.WriteLine(p);
			Console.ReadLine();
		}
	}

	public class Functions
	{
		// a function is a block of code that has  a signature . function is used to execute statments speficied in the code block.
		// a fucntion consists of the following componenet .:
		// function name , return type , body , access specifier , parameters .

		// functions can return alot of things . you can return numbers string and objects as well.
		// examples for functions in C# :

		public static int CalculateMe(int num1,int num2)
		{
			return num1+ num2;      /// here we have a function that returns us a number  and gets 2 numbers in arguments.
		}
		public static void PrintMeSomething(string s)    // this function prints the value we pass to it .
		{
			Console.WriteLine(s);
		}
		public static Person ReturnPerson()
		{
			var person = new Person();	
			person.Name = "Test";
			return person;
		}
	}

	public class Person 
	{
		public string Name { get; set; }
		public override string ToString()
		{
			return this.Name;
		}

	} // just example to return person in function.
}
