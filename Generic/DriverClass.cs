using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class DriverClass
    {
        public static void Main(string[] args)
        {
            GenericAssignment<string> Assignment = new GenericAssignment<string>();

            Console.WriteLine("Please Enter string:");
           string InputString = Console.ReadLine();

            Console.WriteLine("Enter choice: 1.Convert String to Integer    2.Convert String to Date");
            int Choice = Convert.ToInt32(Console.ReadLine());

             

            if(Choice == 1)
            {
              Console.WriteLine(" " + Assignment.Convertor<int>(InputString));
            }
            else if(Choice == 2)
            {
               Console.WriteLine(" " + Assignment.Convertor<DateTime>(InputString));
            }
            else
            {
                Console.WriteLine("Please Enter valid Choice!!!");
            }

        }
    }
}



//        assignment.ConvertString = "120530489";

//        int number = int.Parse(assignment.ConvertString);
//        Console.WriteLine("Number: "+number);

//assignment.ConvertString = " 2022 - 06 - 23";

//DateTime date = DateTime.Parse(assignment.ConvertString);
//Console.WriteLine("Date :"+date);