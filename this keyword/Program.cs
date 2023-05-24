using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// this is a keyword whice tells the object that it points on
			// if we use this keyword in a function it means that this is the object that has the method
			//
		}
	}

	public class Example
	{
		private int num;
		public Example(int num)
		{
			this.num = num;
		}
		public int GetNum(int num) 
		{
			return num; 
		}
	}

	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Person(int id, string name, string description)
		{
			this.Id = id;
			this.Name = name;
			this.Description = description;
		}
	}
}
