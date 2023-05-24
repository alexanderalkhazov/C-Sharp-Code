using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Functional_Programming
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string result = GetResult();
			Console.WriteLine(result);
			Console.ReadLine();
		}

		private static string GetResult()
		{
			string result = null;
			FPStopWatch.LogMs("Took {0} Ms", () =>
			{
				result += ExpensiveMethod();
				result += ExpensiveMethod2();
				result += ExpensiveMethod3();
			});
		    return result;
		}

		private static string ExpensiveMethod()
		{
			Thread.Sleep(2000);
			return "Done1";
		}
		private static string ExpensiveMethod2()
		{
			Thread.Sleep(2000);
			return "Done2";
		}
		private static string ExpensiveMethod3()
		{
			Thread.Sleep(2000);
			return "Done3";
		}

	}

	public static class FPStopWatch
	{
		public static T LogMs<T>(string formattedMessage , Func<T> action)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			T result = action();
			sw.Stop();
			Console.WriteLine(string.Format(formattedMessage,sw.ElapsedMilliseconds));
			return result;
		}
		public static void LogMs(string formattedMessage, Action action)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			action();
			sw.Stop();
			Console.WriteLine(string.Format(formattedMessage, sw.ElapsedMilliseconds));	
		}

	}
	public class MyStopWatch
	{
		private Stopwatch _watch;

		public MyStopWatch() 
		{
			this._watch = new Stopwatch();
		}
		public void Start()
		{
			this._watch.Start();
		}
		public void Stop()
		{
			this._watch.Stop();
		}
		public void LogMs(string FormattedMessage)
		{
			Console.WriteLine(string.Format(FormattedMessage,this._watch.ElapsedMilliseconds));
		}

	}
}
