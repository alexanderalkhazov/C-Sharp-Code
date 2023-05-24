using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_VS_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var vs dynamic 

            // the main difference is that var is strongly type object .
            // that means that at compile time we can get errors and know what to do
            // dynamic object are assigned in run time 
            // it can be risky but sometimes we need to use them .        
        }    
    }
    class Person
    {
        public string Name { get; set; }
    }
}
