using System;

namespace Delegates
{
	public class CalculatorDelegate
	{
		delegate double Calculator(double a, double b);
		static double Add(double a, double b)
		{
			Console.WriteLine(a + b);
			return a + b;
		}
		static double Subtract(double a, double b)
		{
			Console.WriteLine(a - b);
			return a - b;
		}
		static double Divide(double a, double b)
		{
			Console.WriteLine(a / b);
			return a / b;
		}
		static double Multiply(double a, double b)
		{
			Console.WriteLine(a * b);
			return a * b;
		}
	}
}
