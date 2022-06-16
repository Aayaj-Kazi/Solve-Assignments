using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class CollegeStudent : Students
    {
        string failed = "Failed!! Student should Study More.";
        string passed = "Passed!! Congratulations";
        public override string Result(int average, int required)
        {
           if(average < required)
            {
                return failed;
            }
           else
                return passed;
        }

        public static void Main(string[] args)
        {
            Students student = new CollegeStudent();

           // student.ID = 101;
           // student.Name = "Ram";

            Console.WriteLine("Enter Student ID,Name and Avarage marks out of 1000:");
            student.ID = Convert.ToInt32(Console.ReadLine());
            student.Name = Console.ReadLine();
            int average = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Roll No: " +student.ID + "    Name:" + student.Name + "   Result: " + student.Result(average, 300));
        }

       
    }
}
