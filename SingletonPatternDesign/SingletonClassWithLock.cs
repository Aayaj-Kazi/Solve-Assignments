using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesign
{
    public sealed class SingletonClassWithLock
    {
        public string VehicleType { get; set; }

        public string VehicleNumber { get; set; }

        public int ParkingTime { get; set; }

        private static readonly object obj = new object();
        private SingletonClassWithLock()
        {
            Console.WriteLine("In Parameterless constructor");
        }
        private SingletonClassWithLock(string vehicleType, string vehicleNumber)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
        }

        private SingletonClassWithLock(string vehicleType, string vehicleNumber, int parkingTime)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
            ParkingTime = parkingTime;
        }

        private static SingletonClassWithLock instance;
        public static SingletonClassWithLock GetInstance
        {
            get
            {
                if(instance == null)     //Double Checked Locking
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new SingletonClassWithLock();
                    }
                }
                return instance;
            }
        }
    }
}
