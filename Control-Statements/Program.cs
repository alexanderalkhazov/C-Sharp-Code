using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}


	public class IfStatements
	{
		// in C# programming the if statement is used to test the condition , there are various types of if statements. : 
		// if  statement.
		// if else statement 
		// nested if statement 
		// if else if ladder.

		static void Validate()
		{
			// if statement code example :
			if (true) { Console.WriteLine("hey"); }

			// another example . : 
			int a = 1;
			int b = 2;
			int c = 3;
			if (a > b)
			{
				// do this
			}
			else if (b == a)
			{
				// do this 
			}
			else
			{
				// if nothing above meets condition finally i will do this no matter what 
			}

		}
	}

	public class Switches
	{
		// the C# switch statement executes one statement from multiple condtions . it is like if ladder statemnt.
		static void Switch()
		{
			Console.WriteLine("enter number");
			int num = int.Parse(Console.ReadLine());
			switch (num)
			{
				case 10: Console.WriteLine("its 10"); break;
				case 20: Console.WriteLine("its 20"); break;
				case 30: Console.WriteLine("its 30"); break;
				default : Console.WriteLine("none of above."); break;
			}
		}
	}

	public class ForLoops
	{
		// the C# for loop is used to interate a part of the program several times . 
		// syntax 
		// for(int i = 0; i < 10; i++)   {}

		// you can nest loops as well inside one another . 

		static void ForLooper()
		{
			// basic for loop
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("hey");
			}
			// infinity for loop
			for (; ; )
			{
				Console.WriteLine("to infinity and beyond XD");
			}
		}

	}

	public class WhileLoop
	{
		// in C# while loop is used to iterate while a condition is true .
		static void While()
		{
			int num = 0;
			while (num != 10)
			{
				num++;
			}
			// while the number is not 10 it will increment the number until it ends the loop.

			while (true)
			{
				Console.WriteLine("infinity and beyong mannnnn");
			}
		}
		
	}

	public class DoWhileLoops
	{
		// In C# do while loops used to interate it firsly executes then checks the condition .  
		static void DoWhile()
		{
			int num = 0;
			do
			{
				Console.WriteLine(num);
				num++;
			}
			while (num < 10 );
		}
	}

	public class BreakStatement
	{
		// in C# break statement is used to break loop or switch statement . if it meets the condition . 
		/// if we have loops it only breaks the inner loops that it located in ! 
		/// 
		static void Break()
		{
			for (int i = 0; i < 20; i++)
			{
				if (i == 5)
				{
					Console.WriteLine(i);
					break;
				}
			}
		}

	}

	public class ContinueStatements
	{
		// in C# the continue statement is used to continue a loop / program flow when condition is met.
		static void Continue()
		{
			for (int i = 0; i < 20; i++)
			{
				if (i == 5)
				{
					continue;  // will continue the loop and flow of the program you can manipulate something here and not exit loop.
				}

			}
		}
	}

	public class GoTo
	{
		// the c# goto statement is also a known jump statement . it is used to transfer control to other parts of the program  .
		// it can be used to switch control from very deep loops . 
		static void Goto()
		{
		   ineligable: Console.WriteLine("u made it here");

			Console.WriteLine("enter your age\n");
			int age  = int.Parse(Console.ReadLine());
			if (age < 18)
			{
				goto ineligable;
			}
			else
			{
				Console.WriteLine("you are good to vote just dont pick biden :(");
			}
		}
	}
}
