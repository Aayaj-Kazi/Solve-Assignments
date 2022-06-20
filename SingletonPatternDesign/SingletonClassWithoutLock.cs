using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesign
{
    //Parking system
    public sealed class SingletonClassWithoutLock           //sealed , so that it can't be derived
    {
        public string VehicleType { get; set; }

        public string VehicleNumber { get; set; }

        public int ParkingTime { get; set; }

        private SingletonClassWithoutLock()
        {
            Console.WriteLine("In Singleton Class Without Lock");
        }
        private SingletonClassWithoutLock(string vehicleType, string vehicleNumber)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
        }

        private SingletonClassWithoutLock(string vehicleType, string vehicleNumber, int parkingTime) 
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
            ParkingTime = parkingTime;
        }

        private static SingletonClassWithoutLock instance;
        public static SingletonClassWithoutLock GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonClassWithoutLock();

                return instance;
            }
        }
    }
      
}
