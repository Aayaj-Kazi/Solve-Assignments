using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            int[] collection = { 1, 2, 4, 5, 6, 7, 8,3,0 };
            int operator1 = 100;
            try{
                for (int i = 0; i < collection.Length-1; i++)
                {
                    var temp = collection[i + 1];
                    Console.WriteLine(operator1 / temp);

                }
            }
            catch (IndexOutOfRangeException ir)
            { Console.WriteLine("Given Array elemts id exceeding the length of array name of exception is:" + ir); }

            catch ( DivideByZeroException d)
            { Console.WriteLine("Cannot devide any integer by 0 !!  Please give input except 0 and the name of exception is:"+d); }
            
            catch (InvalidCastException ic)
            { Console.WriteLine("Please give integer as input except 0 and the name of exception is:" + ic); }

            catch (Exception e)
            { Console.WriteLine("Specific Exception not found and the name of exception is:" + e); }
        }

    }
}
