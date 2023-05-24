using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
	internal class AllSixPossible1
	{
		public void Method()
		{
			// access all outside class from any assembly .
		} 
	}
	internal class AllSixPossible2
	{
		private void Method()
		{
			// access only inside this type . 
		}
	}
	internal class AllSixPossible3
	{
		protected void Method()
		{
			// access only to those who derive from here . 
		}
	}
	internal class AllSixPossible4
	{
	     protected private void Method()
		 {
			// access only to this class or derived class in the same assembly (dll,exe).
		 }
	}
	internal class AllSixPossible5
	{
		internal void Method()
		{
			// access only in the current assembly (exe , dll). 
		}
	}
	internal class AllSixPossible6
	{
	    protected internal void Method()
		{
			// access only in current assembly (dll,exe) 
		}
	}
}
