using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}


	public class Person
	{
		private string _name;
		public string Name { get; set; }
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public Person() { }

		public string GetName 
		{ 
		     get { return Name; }
		     set { _name = value; }
		}
	}
}
