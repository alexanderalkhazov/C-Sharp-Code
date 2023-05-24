using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// * enable to add methods to existing typea

// * extension methods are a special kind of static method 

// * they must exist in a static class


namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine("Before use of extension method.");
            Console.WriteLine(p.Name);

            // after usage of extension method .
            p.UseExtension();
            Console.WriteLine("after use of my extenstion");
            Console.WriteLine(p.Name);
            Console.WriteLine("_____________________________-");
            FileAccess a = new FileAccess();
            a.UseExtension2();
            Console.ReadLine();
        }
    }


    public static class ExtensionMethodForPerson
    {
        // this extension method will add to person a title 

       public static void UseExtension(this Person p)
       {
            p.Name += string.Format("Title = King");
       } 
       public static void UseExtension2(this FileAccess j)
       {
            Console.WriteLine("Extenstion 2 was called !");
       }
    }


    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = "The Name : Alex Alhazov";
        }
    }
}
