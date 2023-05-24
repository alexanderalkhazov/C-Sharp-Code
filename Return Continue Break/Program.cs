using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Continue_Break
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// return breaks the current scope and exits function.
		    ReturnMethod();

			// continue excutues something when condition if met.
			ContinueMethod();


			// break breaks the current scope for example inner loop.
			BreakMethod();
		
			Console.ReadLine();
		}

		private static void BreakMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (j == 2)
					{
			         	Console.WriteLine("I break");
						break;
					}
				}
			}
		}

		private static void ContinueMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (j == 2)
					{
				        Console.WriteLine("I continue");
						continue;
					}
				}
			}
		}

		private static void ReturnMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (j == 2)
					{
				        Console.WriteLine("I return");
						return;
					}
				}
			}
		}
	}
}
