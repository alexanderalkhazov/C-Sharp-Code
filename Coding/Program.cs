using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Coding
{
	internal class Program
	{
		public static List<Person> people= new List<Person>();


		static void Main(string[] args)
		{
			people.SingleOrDefault(p => p.FirstName == "");

			while(true)
			{
				BasicMessages.WelcomeMessage();
				string newId = BasicMessages.GenerateId();
				string newFirstName = BasicMessages.GetFirstName();
				string newLastName = BasicMessages.GetLastName();
				bool isValid = ValidatePerson.ValidateSomeone(newFirstName, newLastName);
				if (isValid)
				{
					Person newPerson = PersonGenerator.GeneratePerson(newId, newFirstName, newLastName);
					people.Add(newPerson);
				}

				Console.WriteLine("New List Update");
				foreach (var p in people)
				{
					Console.WriteLine($"Person Name {p.FirstName} {p.LastName}");  
				}

				Console.ReadLine();
			}
		}
	}
	public class Person 
	{
		public Person(string id, string firstName, string lastName)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
		}
		public string Id { get; set; } 
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class PersonGenerator 
	{
		public static Person GeneratePerson(string id , string firstName , string lastName) 
		{
			return new Person(id,firstName,lastName);
		}
	}

	public class BasicMessages 
	{
		public static void WelcomeMessage()
		{
			Console.WriteLine("Welcome To Person Generator !");
			Console.WriteLine("Press Any Key To Continue ...");
			Console.ReadLine();
		}
		public static string GenerateId()
		{
			return Guid.NewGuid().ToString();	
		}
		// will get first name and return string 
		public static string GetFirstName ()
		{
			Console.WriteLine("Please Enter First Name :");
			string firstName = Console.ReadLine();
			return firstName;
		}
		// will get last name and return string 
		public static string GetLastName()
		{
			Console.WriteLine("Please Enter Last Name :");
			string lastName = Console.ReadLine();
			return lastName;
		}
	}

	public class ValidatePerson 
	{
		public static bool ValidateSomeone(string field1, string field2) 
		{
			if (string.IsNullOrWhiteSpace(field1) && string.IsNullOrWhiteSpace(field2))
			{
				Console.WriteLine("Error Please Enter A valid Name");
				return false;
			}
			return true;
		}
	}
}