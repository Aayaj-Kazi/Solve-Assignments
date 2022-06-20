using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesign
{
    class DriverClass
    {
        static void Main(string[] args)
        {
            SingletonClassWithoutLock Bike = SingletonClassWithoutLock.GetInstance;
            
            Bike.VehicleType = "Two Wheeler";
            Bike.VehicleNumber = "MH 45 Ak 2099";
            Bike.ParkingTime = 2;

            Console.WriteLine(" " + Bike.VehicleType + "  " + Bike.VehicleNumber + "   " + Bike.ParkingTime);



            SingletonClassWithLock Car=SingletonClassWithLock.GetInstance;
            Car.VehicleType = "Four Wheeler";
            Car.VehicleNumber = "MH 12 EX 0348";
            Car.ParkingTime = 4;

            Console.WriteLine(" " + Car.VehicleType + "  " + Car.VehicleNumber + "   " + Car.ParkingTime);
        }
    }
}
