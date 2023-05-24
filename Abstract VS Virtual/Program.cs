using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_VS_Virtual
{
    // code examples to show difference of virtual and abstract.

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public abstract class AbstractExample
    {
        public abstract void RunAbstract(); // this function doesnt have implemetation and is abstract can only be used in abstract classes
    }

    public class VirtualExample
    {
        public virtual void RunVirtual()
        {
            Console.WriteLine("Running in Virtual"); // here we have virtual method we allow others to override it
            // the main difference the virtual method has an original implementation.
        }
    }


    public class VirtualSonExam : VirtualExample
    {
		public override void RunVirtual()
		{
			base.RunVirtual();
		}
	}


}
