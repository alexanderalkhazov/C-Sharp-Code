using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Coffee coffee = new Coffee(30);
			Coffee Tea = new Coffee(60);
			// with abstract class we can act like coffee and tea are beverages and use them as beverages.
			List<Beverage> beverages= new List<Beverage>();
			beverages.Add(coffee);
			beverages.Add(Tea);
		}
	}

	// in C# we have the concept of OOP all is object in C# . !
	// the objects are reference types .
	// with objects you can define values behaviour 
	// before we talk about objects lets talk about classes . classes are the blueprint for the objects they tell us what values and behaviour the object will have.
	// the class conatins class members whice are known as fields and methods.
	// there are 5 types of classes in C# 
	// 1 . partial 
	// 2 . abstract 
	// 3 . concrete 
	// 4 . sealed 
	// 5 . static 
	// we will learn whats the difference between them!.



	/// first class 
	/// 

	public class Point // all inside of point is called class members.
	{
		int x, y;                                              // class fields.
		Point(int x, int y)
		{               
			this.x = x;
			this.y = y;                                      // class constructor.
		}

		~Point() { }	                                      // class deconstructor

		public void GiveMepoint()                                // class method 
		{
			Console.WriteLine($"x is {this.x} , y is {this.y}");
		}
	}


	// inheritance example.
	public class Person   // the base class that all will inherit from .
	{
		private string _name;
		private string _lastName;

		public Person(string name, string lastName)
		{
			_name = name;
			_lastName = lastName;
		}
	}
	 // now that we inherited from person the types student and teacher will have name and last name when we create them .
	 // and the best thing they will be able to do their own thing as well .
	public class Student : Person  
	{
		public Student(string name, string lastName) : base(name, lastName)
		{
		}
		public void Study()
		{
			Console.WriteLine("studying");
		}
	}

	public class Teacher : Person
	{
		public Teacher(string name, string lastName) : base(name, lastName)
		{
		}
		public void Teach()
		{
			Console.WriteLine("Teaching");
		}
	}


	/// abstract class Examle . 
	/// 

	public abstract class Beverage
	{                                      /// we created this abstract class to achive abstracticm in programming .
		                                   // we cannot instance an abstract class.!!!
		private double _price;
		public Beverage(double price)
		{
			_price = price;
		}
		public abstract void Prepare();
	}
	// now who ever inherit from the abstract class will implement the prepare method as he wishes ..
	public class Coffee : Beverage
	{
		public Coffee(double price) : base(price)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine("coffee done in its own way ! ");
		}
	}

	public class Tea : Beverage
	{
		public Tea(double price) : base(price)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine("Tea done in its own way ! ");
		}
	}
	// this is the old way to achive abstracticm in C# we now have interfaces.

	// static class Example 
	// a static class cannot be instanced 
	// a static constructor cannot have parameters and cant have access modifiers !!!.
	public static class Tools      
	{
		private static int _tools;
	    static Tools()
		{
			_tools = 20;
		}
	}
}
