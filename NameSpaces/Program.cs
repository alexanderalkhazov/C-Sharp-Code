using NameSpace1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NameSpaces.


// namespaces in C# are used to organize too many classes so that it can be easy to handle the application .
// to use a namespace we have to add reference to project with namespace and use 'using' keyword to use it .
// in C# the global namespace is the root namespace. the global :: system will always refer to the system of .net framework.



/// not lets see code example and learn !.
/// 
namespace NameSpaces
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            NameSpace1.NameSpaceOneClass name1 = new NameSpace1.NameSpaceOneClass(); // to do this we need to use namespace !
            NameSpace2.NameSpaceTwoClass name2 = new NameSpace2.NameSpaceTwoClass(); // to do this we need to use namespace !

            Console.ReadLine();
        }
    }
}   // here is the example name space we will run all here .!

namespace NameSpace1
{
    class NameSpaceOneClass
    {
        public NameSpaceOneClass()
        {
            Console.WriteLine("Hello from name space one");
        }
    }
}

namespace NameSpace2
{
    class NameSpaceTwoClass
    {
        public NameSpaceTwoClass()
        {
            Console.WriteLine("hello from name space two");
        }
    }
}
