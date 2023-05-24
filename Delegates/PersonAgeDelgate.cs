using System;

namespace Delegates
{
	public class Person
	{
		public int Age { get; set; }


		private static void CallIt()
		{
			Person p = new Person();
			p.Age = 71;
			var resultUI = Delegator(p, IsOld);
			Console.WriteLine(resultUI);
		}

		static bool Delegator(Person personon, Func<Person, bool> func)
		{
			var res = func(personon);
			return res;
		}

		static bool IsOld(Person p)
		{
			if (p.Age >= 70)
				return true;
			return false;
		}
		static bool IsAdult(Person p)
		{
			if (p.Age >= 21 && p.Age <= 69)
				return true;
			return false;
		}
		static bool IsYoung(Person p)
		{
			if (p.Age <= 20)
				return true;
			return false;
		}
	}
}
