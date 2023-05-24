using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	

	/// a struct is used to create a value schema that we will not want to change in our program
	/// like maybe some math Stuff that will stay .
	/// structs in C# are value types and are used for light weight data .
	///  sstruct example.
	
	public struct Rectangle
	{
		public int x;
		public int y;
		public int Width;
		public int Height;
	}

	// and we have in C# the value type enum whice is used to store constants for example days , seasons and such.
	public enum Seasons
	{
		Winter,
		Automn,
		Summer,
		Spring
	}
	



}
