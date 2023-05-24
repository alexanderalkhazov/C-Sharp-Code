using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Converting_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            int number = 5;
            double num = 10.5;


            // 1. implicit conversion -

            // this is __implicit__ casting
            num = number;

            // 1. implicit conversion -

            // this is casting this is the form 
            // by the way this is __explicit__ casting
            number = (int)num;
            #endregion
            #region Conversion
            string text = "1234";
            //int b = (string)text; // you cant do it so we use convert class
            // conversion
            int numnum = Convert.ToInt32(text);
            #endregion
            #region Parsing
            int aaa = int.Parse(Console.ReadLine()); 
            #endregion

            // the difference between convert and parse is that 
            // convert takes objects
            // parse takes string
            // convert if you pass null will return  0
            // parse will throw null exception.

        }
    }
}
