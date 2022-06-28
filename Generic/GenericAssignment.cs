using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericAssignment<T>
    {//convert String to number and string to date
       

        public dynamic Convertor<T>(string input)
        {
            //Use switch case instead of if else
            switch (typeof(T).Name)
            {
                case "Int32":
                   var result = int.Parse(input);
                    return result;
                    break;

                case "DateTime":
                    var resultDate = DateTime.Parse(input);
                    return resultDate;
                    break;

                default:
                    return null;
                    break;
                   
            }




            //if(typeof(T) == typeof(int))
            //{
            //    var result = int.Parse(input);
            //    //return number;
            //    Console.WriteLine(" " + result);
            //}


            //else if (typeof(T) == typeof(DateTime))
            //{
            //    var result = DateTime.Parse(input);
            //    // return date;
            //    Console.WriteLine(" " + result);
            //}




        }

    }

   
}
