using System;
using System.Collections;

// Types and variables
//

//  A type defines the structure and behavior of any data in C#.
//  The declaration of a type may include its members, base type,
//  interfaces it implements,
//  and operations permitted for that type.
//  A variable is a label that refers to an instance of a specific type.


// There are two kinds of types in C#: value types and reference types.
// Variables of value types directly contain their data.
// Variables of reference types store references (address) to their data , the latter being known as objects.
//  With reference types,
//  it's possible for two variables to reference the same object and possible for operations
//  on one variable to affect the object referenced by the other variable.
// With value types, the variables each have their own copy of the data,
// and it isn't possible for operations on one to affect the other (except for ref and out parameter variables).
// An identifier is a variable name. An identifier is a sequence of unicode characters without any whitespace.
// An identifier may be a C# reserved word,
// if it's prefixed by @.
// Using a reserved word as an identifier can be useful when interacting with other languages.
// 

// C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types.

// C#'s reference types are further divided into class types, interface types, array types, and delegate types.

// all system types : 

// Value Types (simple types) :


// signed integral : sbyte , int , short , long
// unsigned integral : byte , ushort , uint , ulong .
// unicode characters : char whice represents a UTF-16 code unit
// binary floating point : float , double.
// high precision decimal floating-point : decimal.
// boolean : bool whice represents boolean values true or false.


// value types (enum types) :
// User-defined types of the form enum E {...}.
// An enum type is a distinct type with named constants. Every enum type has an underlying type,
// which must be one of the eight integral types.
// The set of values of an enum type is the same as the set of values of the underlying type.


// value types (Structs) : 
// User-defined types of the form struct S {...}


// value types (Nullable Types .) : 
// Extensions of all other value types with a null value


// Value Types (Tuples) :
// user defined types of the form (t1,t2,t3)





// Reference Types : 

// Class Types : Ultimate base class of all other types: object
// A class type defines a data structure that contains data members (fields) and function members (methods, properties, and others).
// Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.


// UniCode Strings string : which represent a sequence of UTF 16 code units .



// Interface Types :  User-defined types of the form interface I {...}
// An interface type defines a contract as a named set of public members.
// A class or struct that implements an interface must provide implementations of the interface's members.
// An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.



// Array Types : Single-dimensional, multi-dimensional, and jagged. For example: int[], int[,], and int[][]


// Delegate Types : User-defined types of the form delegate int D(...)
// A delegate type represents references to methods with a particular parameter list and return type.
// Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters.
// Delegates are analogous to function types provided by functional languages.
// They're also similar to the concept of function pointers found in some other languages.
// Unlike function pointers, delegates are object-oriented and type-safe.





// The class, struct, interface, and delegate types all support generics, whereby they can be parameterized with other types.


// There are several kinds of variables in C#, including fields, array elements,
// local variables,
// and parameters. Variables represent storage locations.
// Every variable has a type that determines what values can be stored in the variable, as shown below.

// Non-nullable value type
// A value of that exact type

// Nullable value type
// A null value or a value of that exact type

// object
// A null reference, a reference to an object of any reference type, or a reference to a boxed value of any value type

// Class type
// A null reference, a reference to an instance of that class type, or a reference to an instance of a class derived from that class type

// Interface type
// A null reference, a reference to an instance of a class type that implements that interface type, 
// or a reference to a boxed value of a value type that implements that interface type.

// Array type
// A null reference, a reference to an instance of that array type, or a reference to an instance of a compatible array type

// Delegate type
// A null reference or a reference to an instance of a compatible delegate type



namespace Types
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gay");
			Console.ReadLine();
		}
	}


	// Classes 

	public class Point
	{
		public int X { get; }
		public int Y { get; }

		public Point(int x, int y) => (X, Y) = (x, y);
	}

	// Structs
	public struct Point2
	{
		public double X { get; }
		public double Y { get; }

		public Point2(double x, double y) => (X, Y) = (x, y);
	}

	// Interfaces

	interface IControl
	{
		void Paint();
	}

	interface ITextBox : IControl
	{
		void SetText(string text);
	}

	interface IListBox : IControl
	{
		void SetItems(string[] items);
	}

	interface IComboBox : ITextBox, IListBox { }


	// Enums
	[Flags]
	public enum Seasons
	{
		None = 0,
		Summer = 1,
		Autumn = 2,
		Winter = 4,
		Spring = 8,
		All = Summer | Autumn | Winter | Spring
	}

	// Nullable types
	class NullableExmp
	{
		void Method ()
		{
			//int? optionalInt = default;
			//optionalInt = 5;
			//string? optionalText = default;
			//optionalText = "Hello World.";
		}
	}
	// Tuples

	class TuplesExmp
	{
		(double Sum, int Count) t2 = (4.5, 3);
		void Func()
		{
			Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
		}
	}

}
