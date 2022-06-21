using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookApp
{
    class IntraCity : Taxi
    {
        public string CalculateBill()
        {
            string result = "";
            Console.WriteLine("Enter appoximate distance in KM: ");
            int distance=Convert.ToInt32(Console.ReadLine());
            if(distance>0 && distance < 20)
            {
                result = "Your bill is Rs. 100";
            }
            else if(distance>20 && distance< 50)
            {
                result = "Your Bill is Rs. 250";
                
            }
            else
            {
                result = "Please Enter Distance less than 50 Kilometer";
            }
            return result;
        }   

        public bool TaxiBooking(string destination)
        {
            if (destination == null)
                return false;
            return true;
        }
    }
}
