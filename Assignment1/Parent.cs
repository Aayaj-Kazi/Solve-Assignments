using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Parent
    {
        public abstract void Name();

        public abstract void Descripton();


        public void age(int age) {
            Console.WriteLine("parent's age is: "+age); }  
    }

    

}
