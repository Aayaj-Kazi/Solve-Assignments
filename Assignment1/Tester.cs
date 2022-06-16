using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Tester
{
    static void Main(string[] args)
        {
            int age = 20;
            string str = "This is Overloaded Method";
            child c1=new child();
            c1.Descripton();
            c1.age(age);
            c1.Descripton(str);        }
}
}
