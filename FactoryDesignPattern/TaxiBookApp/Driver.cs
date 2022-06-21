using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookApp
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Travel type : 1)Intracity  2)Intercity");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Taxi swift=new IntraCity();
                    Console.WriteLine("Enter Destination: ");
                    string destination=Console.ReadLine();
                    swift.TaxiBooking(destination);
                    Console.WriteLine(""+ swift.CalculateBill()); 
                        break;

                    case 2:
                    Taxi innova=new InterCity();
                    Console.WriteLine("Enter Destination: ");
                    string city = Console.ReadLine();
                    innova.TaxiBooking(city);
                    Console.WriteLine(""+ innova.CalculateBill()); 
                    break;
            }
        }
    }
}
