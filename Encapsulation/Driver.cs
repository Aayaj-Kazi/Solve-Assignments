using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Driver
    {
        public static void Main(string[] args)
        {
            Students student = new Students();
           // student.SetID(1);
           // student.SetName("Aryan");

            

            Console.WriteLine("Enter Student ID & Name:");
            
            student.SetID(Convert.ToInt32(Console.ReadLine()));
            student.SetName(Console.ReadLine());

            Console.WriteLine("Students Info : Id:"+student.GetID()+" name:"+student.GetName());
         }
    }
}
