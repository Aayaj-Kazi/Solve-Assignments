using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookApp
{
    class InterCity : Taxi
    {
        public string CalculateBill()
        {
            string result = "";
            Console.WriteLine("Enter appoximate distance in KM: ");
            int distance=Convert.ToInt32(Console.ReadLine());
            if (distance > 0 && distance < 100)
            {
                result = "Your bill is Rs. 1500";
            }
            else if (distance > 100 && distance < 250)
            {
                result = "Your Bill is Rs. 4000";

            }
            else if ( distance > 250)
            {
                result = "Taxi not available";

            }
            else
            {
                result = "Please Enter Distance more than 100 Kilometer";
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
