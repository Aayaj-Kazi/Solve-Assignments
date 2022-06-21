using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesign
{
    public sealed class VehicleParkingWithLock
    {
        public string VehicleType { get; set; }

        public string VehicleNumber { get; set; }

        public int ParkingTime { get; set; }

        private static readonly object obj = new object();
        private VehicleParkingWithLock()
        {
            Console.WriteLine("In Singleton Class With Lock");
        }
        private VehicleParkingWithLock(string vehicleType, string vehicleNumber)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
        }

        private VehicleParkingWithLock(string vehicleType, string vehicleNumber, int parkingTime)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
            ParkingTime = parkingTime;
        }

        private static VehicleParkingWithLock instance;
        public static VehicleParkingWithLock GetInstance
        {
            get
            {
                if(instance == null)     //Double Checked Locking
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new VehicleParkingWithLock();
                    }
                }
                return instance;
            }
        }

        public int PayForPark(int parkingTime)
        {
            int fee = parkingTime * 100;
            return fee;
        }
    }
}
