using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

	// .NET Framework class library is the collection of classes , namespaces, interfaces and value types that are used for .NET apps.
	// it contains huge amount of classes that support the following functions .
	// * Base and user defined data types.
	// * Support for exception handling .
	// * Input/Output and stream operations  .
	// * communications with the underliyng system.
	// * access to data 
	// * ability to create windows gui apps.
	// * ability to create web-client and server apps.
	// * support for creating web services.

	/// <summary>
	/// /////////////////////// BASE Class Library .  // System.Web // system.data // system.collection // system.IO and so much more !
	/// with those you can create your app.
	/// </summary>
	///                        now i will write in different projects code examples and more. this is the basics .

	internal class Program
	{  // some code examples.
		static void Main(string[] args)
		{

		}

	}

	public class Variables
	{
		int number1 = 10;
		byte bite = 1;
		float numb = 44;
		long big = 555;
		double number2 = 20.5;
		decimal hugeNum = decimal.MaxValue;
		string words = "hey there";
		char tav = 'A';
		bool isTrue = true;
		bool isFalse = false;
		Nullable<bool> nullable = null;
	}

	public class DataTypes
	{
		/// in C# we have 3 types of data types 
		/// 1. value types  examples : int , long , double ,struct
		/// 2. reference types. example : string , object , interface.
		/// pointer types. //   int * a;  //  Pointer example. 
	}

	public class Operatores
	{
		// in C# we have 8 types of operatores . 


		// 1. Arithmetic Operatores.         (Math) examples : + - * / % 
		// 2. Relational Operators.          to relate between example : < , > , <= , >= , == , != 
		// 3. Logical Operatores.            to say AND , OR , NOT . Example :     ! , || , && 
		// 4. Bitwise Operatores.            & , | , << , >> , ~ , ^ 
		// 5. Assignment operatores          = , += , =+ , -= , =- , *= , =* , /= , =/ , %=, =%
		// 6. Unary Operatores .             ++ , -- 
		// 7. Ternary Operatores .           ternary operatores ? . used to condition .
		// 8. Misc Operatores.
	}
}
