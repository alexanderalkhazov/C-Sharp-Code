using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableExmp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (Person person = new Person())
			{
				person.Name = "Test";
				person.PrintName();
			}
			Console.ReadLine();
		}
	}

	public class Person : IDisposable
	{
		public string Name { get; set; }

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public void PrintName ()
		{
			Console.WriteLine(Name);
		}
	}
}
