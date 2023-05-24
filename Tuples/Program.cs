using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
	// tuples are light weight data structures to use when you want to return multiple values from method
	// when you want to pass multiple values to methods with single parameter.
	// when you want to hold some record temporarly without creating a class for it.

	public class Person
	{
		public int Id { get; set; }

		public Person(int id)
		{
			Id = id;
		}
		public void Method()
		{
			(Person person, int age) tup = (new Person(1), 23);
			tup.person = new Person(2);

			var person = Tuple.Create(1, "Alex", "Alhazov");
			Console.WriteLine(person.Item2);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine();
		}
	}
}
