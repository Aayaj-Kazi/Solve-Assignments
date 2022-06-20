using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class DriverClass
    {
        public static void Main(string[] args)
        {
          //Console.WriteLine("Enter Choice:");
          //int choice=Convert.ToInt32(Console.ReadLine());

                    GenericAssignment<string> assignment = new GenericAssignment<string>();
                    assignment.str = "120530489";

                    int number = int.Parse(assignment.str);
                    Console.WriteLine(number);

            assignment.str = " 2022 - 06 - 20";
           
            DateTime date = DateTime.Parse(assignment.str);
            Console.WriteLine(date);

           
        }
    }
}

