using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // this is the first kind of using and it's for using directive
//using System.Threading.Tasks;



// second use of using is for all types that are IDisposable
// it used method dispoase() .
//


namespace Using_KeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = "aaaa";
            using (var file = new FileStream(filePath,FileMode.OpenOrCreate))  // using keyword here 
            {
                // some code here
            }// when we reach end of scope with use the Dispose method whice disposes of object for us .

        }
    }
}
