using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsRefAndOut
{
	internal class RefVsOut
	{
		static void Main(string[] args)
		{
			// ref
			Console.WriteLine("Ref!!! \n");
			int i = 1;
			int j = 1;
			Console.WriteLine("Previous value of integer i: " + i.ToString());
			string text  = GetNextName(ref i);
			Console.WriteLine("current value of integer i: " + i.ToString());

			//out 

			Console.WriteLine("Out !!! \n");
			Console.WriteLine("previous value of integer i :" + j.ToString());
			string text2 = GetNextByOut(out j);
			Console.WriteLine("current value of integer i: " + j.ToString());
			Console.ReadLine();

		}
		static string GetNextName(ref int id)
		{
			
			string returnText = "Next-" + id.ToString();
			id += 1;
			return returnText;
		}

	    static string GetNextByOut(out int id)
		{
			id = 10;
			string returnText = "next-" + id.ToString();
			return returnText;
		}
	}


}
