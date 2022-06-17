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
            
            int[] collection = { 1, 2, 4, 5, 6, 7, 9, 5, 8,3,0 };
            int operator1 = 100;
            try
            {
                for (int i = 0; i < collection.Length - 1; i++)
                {
                    var temp = collection[i + 1];
                    Console.WriteLine(operator1 / temp);
                    throw new NumberException();
                }
            }
           
            catch (NumberException ex)
            {
                Console.WriteLine(ex);
            }

            catch (IndexOutOfRangeException limitException)
            { Console.WriteLine("Message:" + limitException.Message + " Source:" + limitException.StackTrace); }

            catch (DivideByZeroException divZero)
            { Console.WriteLine("Cannot devide any integer by 0 !!:" + divZero.StackTrace); }

            catch (InvalidCastException ex)
            { Console.WriteLine("Please give integer as input except 0 and the name of exception is:" + ex.Message); }


            catch (Exception e)
            { Console.WriteLine("Specific Exception not found and the name of exception is:" + e); }
        }

    }
}
