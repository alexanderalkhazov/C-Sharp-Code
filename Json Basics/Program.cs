using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Json_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() {Id = 1,Name = "Alex" };

            var path = "file.Json";
            string jsonString = JsonConvert.SerializeObject(person);
           
           
            File.WriteAllText(path, jsonString);
            var readResult = File.ReadAllText(path);

            var jsonResultRead = JsonConvert.DeserializeObject(readResult);

            Console.WriteLine("i Did it");
            Console.WriteLine("Json After I read it \n \n ");
            Console.WriteLine(jsonResultRead);
            Console.ReadLine();
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
