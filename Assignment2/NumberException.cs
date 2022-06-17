using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class NumberException : Exception
    {
        public NumberException() //parameter less constructor
        {
            Console.WriteLine("In Number Exception Class's Constructor");
                }
        public NumberException(string message) : base("Try another  number") { }
    }
}
