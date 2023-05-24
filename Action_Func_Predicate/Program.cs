using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// how to work with func/action/predicate 



// the most common delegates in C# are Func And Action .
// both are reference types of course.
// Func - gets parameters and returns something to us .
// Action - Get Parameters and doesnt return us anything but can preform something.



namespace Action_Func_Predicate
{
    public class Example1
    {
		public Example1() 
		{

			// lets start with action .
			Action<int, string> actionDelegate = new Action<int, string>(ActionExample);
			actionDelegate(1, "Hey");
			

			// now with func 
			Func<int ,string> funcDelegate = new Func<int, string>(FuncExample);
			var res = funcDelegate(55);


			// and now predicate .
			List<string> list = new List<string>()
			{
				"1","2","3","4",
			};
			Predicate<string> result = x => x.Contains("1");
			string wordFound = list.Find(result);

			Console.WriteLine(wordFound);
			Console.ReadLine();
		}
		static void ActionExample(int a, string s)
		{
			Console.WriteLine(a + " " + s + "Action Done");
		}
		// function for func 
		static string FuncExample(int s)
		{
			Console.WriteLine(s + " the func is done");
			return s.ToString();
		}
	}

	public class Example2
	{
		private double _num1;
		private double _num2;

		public Example2(double num1, double num2)
		{
			_num1 = num1;
			_num2 = num2;
		}

		public void InvokeCalculator()
		{
			
		}
	}


    internal class Program
    {
        static void Main(string[] args)
        {

        }    
    }
}
