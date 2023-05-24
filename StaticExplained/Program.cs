using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// with static we dont need to create instance of an object
// static never dies while program runs.
// static cant be inheritaned



// code examples 
namespace StaticExplained
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Entity.SetNextSerialNo(1000);
			Entity e1 = new Entity();
			Entity e2 = new Entity();
			Console.WriteLine(e1.GetSerialNo());          // Outputs "1000"
			Console.WriteLine(e2.GetSerialNo());          // Outputs "1001"
			Console.WriteLine(Entity.GetNextSerialNo());
			Console.ReadLine();    
        }
    }



    public class Entity
    {
		static int s_nextSerialNo;
		int _serialNo;
		public Entity()
		{
			_serialNo = s_nextSerialNo++;
		}

		public int GetSerialNo()
		{
			return _serialNo;
		}
		public static int GetNextSerialNo()
		{
			return s_nextSerialNo;
		}

		public static void SetNextSerialNo(int value)
		{
			s_nextSerialNo = value;
		}
	}

    public static class Tools
    {
        public static int number;
        // no access modifier is allowed
        static Tools() // static constructor is used to initialize static members .
        {
            number = 0;
        }
        public static void Increment()
        {
            number++;
        }
    }
}
