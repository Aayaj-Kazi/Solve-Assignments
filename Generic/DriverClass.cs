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
                    assignment.ConvertString = "120530489";

                    int number = int.Parse(assignment.ConvertString);
                    Console.WriteLine("Number: "+number);

            assignment.ConvertString = " 2022 - 06 - 23";
           
            DateTime date = DateTime.Parse(assignment.ConvertString);
            Console.WriteLine("Date :"+date);

           
        }
    }
}

