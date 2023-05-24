using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AccessModifiers
{
    class Info
	{
		// here i will talk about encapsulation in oop programming

		//Access modifiers are keywords used to specify the declared accessibility of
		//a member or a type.This section introduces the five access modifiers:

		//public
		//protected
		//internal
		//private
		//file (C# 11 or greater)



		//public: Access isn't restricted.
		//protected: Access is limited to the containing class or types derived from the containing class.
		//internal: Access is limited to the current assembly.
		//protected internal:
		//Access is limited to the current assembly or types derived from the containing class.
		//private: Access is limited to the containing type.
		//private protected:
		//Access is limited to the containing class or types derived from the containing class within the current assembly.
		//file: The declared type is only visible in the current source file.
		//File scoped types are generally used for source generators.


	}
}
