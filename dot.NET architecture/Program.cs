using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot.NET_architecture
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// C# programs run on .NET, a virtual execution system called the common language runtime (CLR) and a set of class libraries.
			// The CLR is the implementation by Microsoft of the common language infrastructure (CLI), an international standard.
			// The CLI is the basis for creating execution and development environments in which languages and libraries work together seamlessly.
			// Source code written in C# is compiled into an intermediate language (IL) that conforms to the CLI specification.
			// The IL code and resources, such as bitmaps and strings, are stored in an assembly, typically with an extension of .dll. 
			// An assembly contains a manifest that provides information about the assembly's types, version, and culture.

			// When the C# program is executed, the assembly is loaded into the CLR. The CLR performs Just-In-Time (JIT)
			// compilation to convert the IL code to native machine instructions.

			//  The CLR provides other services related to automatic garbage collection, exception handling, and resource management.

			//  Code that's executed by the CLR is sometimes referred to as "managed code."
			//  "Unmanaged code," is compiled into native machine language that targets a specific platform.

			// Language interoperability is a key feature of .NET. IL code produced by the C# compiler conforms to the Common Type Specification (CTS).

			// IL code generated from C# can interact with code that was generated from the .NET versions of F#, Visual Basic, C++. 

			//  There are more than 20 other CTS-compliant languages.
			//  A single assembly may contain multiple modules written in different .NET languages.
			//  The types can reference each other as if they were written in the same language.

			//  so basically this is what is going on behind the scene in .NET systems .
			// you have the source code first that is compiled into by the language compiler into IL code whice is familiar in all .NET languages.
			// then we generate an assembly (DLL) and inside an assembly we can have different .NET languages referencing each other .
			// then when we execute the assembly it is managed by the CLR Into Native code that the machine understands.

			// Source Code > Language Compiler > IL code > JIT managed in CLR > Native Code .

		}
	}
}
