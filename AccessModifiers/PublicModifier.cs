using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
	public class PublicPerson
	{
		private string _id;
		private int _age;
		private string _fullName;
		private char _gender;
		public PublicPerson(int age, string fullName, char gender)
		{
			this._id = IdGenerator();
			this._age = age;
			this._fullName = fullName;
			this._gender = gender;
		}
		private string IdGenerator()
		{
			return Guid.NewGuid().ToString();
		}
		public int Age { get { return _age; } }
		public string FullName { get { return _fullName;} }
		public char Gender { get { return _gender;} }
		public override string ToString()
		{
			return $"{this._id}";
		}
	}
	public class SuperHero
	{

		private string _name;
		private string _specialPower;
		private int _powerLevel;
		protected SuperHero(int powerLevel , string specialPower, string name)
		{
			this._powerLevel = powerLevel;
			this._specialPower = specialPower;
			_name = name;
		}
		public int PowerLevel
		{
			get 
			{
				return this._powerLevel;
		    }
		}
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		public string SpecialPower
		{
			get
			{
				return this._specialPower;
			}
		}
		public override string ToString()
		{
			return $"SuperHero Name : {this._name}";
		}
	}

	public class BatMan : SuperHero
	{
		public BatMan() : base(1000, "KickBat!!!", "BatMan") { }
	}
	public class WonderWoman : SuperHero
	{
		public WonderWoman() : base(1200, "Kick Spank Bang!!!", "Wonder Woman") { }
	}
	public class SpiderMan : SuperHero
	{
		public SpiderMan() : base(2000, "Web Strike Style!!!" , "Spider Man") { }
	}
}


