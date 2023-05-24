using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	internal class Program
	{
		static void Main(string[] args)
		{
			 var buttonMaster = new ButtonMaster();

			buttonMaster.ButtonPressed += (sender, eventArgs) =>
			{
				Console.WriteLine($"Button Was Pressed");
			};

			Start:

		    var KeyCode = Console.ReadKey(true).KeyChar;
			buttonMaster.OnButtonPressed(KeyCode);

			goto Start;
		}
	}
	public class ButtonMaster
	{
		public event EventHandler ButtonPressed;

		public void OnButtonPressed(char keycode)
		{
			ButtonPressed.Invoke(this, new EventArgs());
		}
	}
}
