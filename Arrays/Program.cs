using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.ReadLine();
			int[] arr = { 1, 2, 3, 4, 5, 50, 7, 20, 9, 10, 11};
			Array.Sort(arr);
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();

			ArrayList array= new ArrayList();
			array.Add(1);
			array.Add("Alex");
			foreach (var i in array)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
			Console.ReadLine();

			LinkedList<string> strings= new LinkedList<string>();
			strings.AddFirst("a");
			strings.AddFirst("b");
			Console.WriteLine(strings.Count);
			Console.ReadLine();

			//JaggedArrays.JaggedArray();
			//Params.Show(1,2,3,4,5,6);
			ArrayClassExmp.UseageOfArrayClass();
			Console.ReadLine();
		}
	}

	// like  other programming languages arrays in C# is a group of similiar types of elemnents that have contiguous memory location .
	// in C# array is an object of base type System.Array. in C# array's index starts from 0 like most programming languages.

	// in C# arrays are fixed size unlike javascript.
	// arrays have 3 types in C# 1. single dimensional arrays 2. multidimensional arrays 3. Jagged Arrays.
	// this is how we declare an array :int

	public class ArrayStuff
	{
		int[] ints = new int[10];   /// here i declared an array with fixed size 10
		int[] ints2 = new int[6]{1,2,3,4,5,6}; // declare it like this with fixed values and indexers.
		int[] ints3 = new int[] { 1, 2, 3, 4, 5,}; // here i declared an array 
		int[] ints4 = {1,2,3,54,6,7,8,9,0 };
		/// you can create functions that get arrays as a argument.
		/// 

		static void PrintMeArray(int[] arr)
		{
			foreach (var elm in arr)
			{
				Console.WriteLine(elm);
			}
		}


		
	}

	public class MultiDimensionalArray
	{
		/// the multidimensional array can store values in a matrix .
		/// formation of row * column .
		/// example.
		int[,,] d3d= new int[3,2,1]; // 3d array 
		int[,] d2d= new int[3,1]; // 2d array 

	}

	public class JaggedArrays
	{
		// the jagged array is a lot different than the multiD arrays . it is essentialiy an array of arrays.
		// example: 
	    
		public static void JaggedArray()
		{
			int[][] arr = new int[2][];
			arr[0] = new int[] {1,2,3,4,5};
			arr[1] = new int[] {6,7,8,9,10};

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.WriteLine(arr[i][j]+ " ");
				}
				Console.WriteLine();
			}
		}

	}

	public class Params
	{
		// In C# params is a keyword whice is used to specifie a parameter that takes variable number of arguments.
		// it is useful when we dont know the number of arguments prior . 
		// only one params keyword is allowed and no additional parameters .

		public static void Show(params int[] val)
		{
			foreach (var item in val)
			{
				Console.Write(item + ",");
			}
		}
	}

	public class ArrayClassExmp
	{
		// C# provides an array class to deal with array related operations . it provides methods for creating , manipulating , searching 
		// and sorting elements of an array . this class works as the base class for all the array in .NET programming envioroment.
		public static void UseageOfArrayClass() 
		{
			int[] array = new int[] { 1, 2, 3,60,66,45,3,4,6,88,3 };
			Array.Sort(array);   /// small example of what we can do with array class.!!
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
		
	}

	
}
