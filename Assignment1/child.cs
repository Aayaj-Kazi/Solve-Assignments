using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class child : Parent
    {
        public override void Descripton()
        {
           Console.WriteLine("In child class by desc method");
        }

        public void Descripton(string info)
        {
            Console.WriteLine("In child class by desc method overloaded");
        }

        public override void Name()
        {
            Console.WriteLine("In child class by name method");
        }

        public void age(int age)
        {
            Console.WriteLine("In child class, child's age is:"+age);
        }

    }
}
