using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Management
{
    // lets talk about memory management in the .NET framework .
    // in the .NET framework we have the clr whice managaes memory allocation for us the developers.
    // unlike native languages like C and C++ we have the .NET doing the hard work to manage our memory !
    // in .NET we have The Garabge collector whice is used in auto mode to collect unused objects from the heap.
    // the garbage collector has 3 generations 0 1 2
    // the first generation is used to manage small objects 
    // the second one is used to manage midium sized objects 
    // the third is used to manage large objects in the large object heap.

    // when we lose the roots to the variable from the stack to the heap the garbage collector will collect the object at random time.
    // lose roots i mean by the that we lose reference .
    internal class Program
    {
        // difference bewtween finalize(); and dispose();
        // these methods are the methods C# uses to free unmanaged resources held by an object . 
        // The Dispose(); method is defined inside  the interfaces IDisposable wheres the method finalize() is defined inside class object 
        // the main difference between dispose() and finalize() is that the method dispose() has to be explicitly invoked by the user
        // wheres the finalize is invoked by the garabage collector just before the object is destroyed .
        //
        //
        static void Main(string[] args)
        {
            //Release by Dispose
            using (A a = new A())   
            {
                a.Work();    
            }

            //Release by D-tor (Destractor)
            A a_old = new A();
            a_old.Work();
        }  /// code 
    }

    class A : IDisposable
    {
        private readonly B b = new B();
        public A() 
        {
            Console.WriteLine("Connect A");
        }


        public void Work()
        {
            Console.WriteLine("Work A");
        }

        public void Dispose()  
        {
            Disconnect();   
            GC.SuppressFinalize(this);
        }

        ~A()  // deconstrctor
        {
            Disconnect();
        }

        private void Disconnect()  
        {
            b.Dispose();
            Console.WriteLine("Disconnect A");
        }
    }  // code 

    class B : IDisposable
    {
        public B()  
        {
            Console.WriteLine("Connect B");
        }
        public void Work()  
        {
            Console.WriteLine("Work B");
        }

        public void Dispose()   
        {
            Console.WriteLine("Disconnect B");
            GC.SuppressFinalize(this);
        }

        ~B()  
        {
            Console.WriteLine("Disconnect B");
        }
    } // code
}



////   1) memory management in .NET is automatic
////      garbage collector is used when a scope  ends and there is no more use for object .
////      when the object is no longer referenced to be clear.
////
////   2) Momory Management is not resource management .
////      you need to take responsibillity for the resources that are used in your app or you may run the system out of them.
////
////   3) IDisposable allows for deterministic resource allocation .
////      gives the developer the ability to say "im done with those resources please dispose of them " .
////
////   4) Finalizers are a non deterministic safety net for freeing unmanaged resources.
///       in case the user didn't dispose of resources the finalizer can execute to fre those resources.
////
////   5)  IDisposable and finalizer are easy to get wrong .
////       to implement them you need to understand them propely because to implement there are alot of things that need to be correct
////



namespace ResourceManagemnt
{
    class Example
    {

    }
}