using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesignUpdated
{
    sealed class DriveTrain
    {
      
        public string direction { get; set; }

        private int count = 0;
        private DriveTrain()
        {
            count++;
            Console.WriteLine("Object of DriveTrain " + count);
            
        }

        private static DriveTrain instance;
        private static readonly object obj = new object();
        public static DriveTrain getInstance{
            get
            {
                if (instance == null)     //Double Checked Locking
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new DriveTrain();
                    }
                }
                return instance;
            }
        }

        public bool Drive(string direction)
        {
            if(direction == "forward") { return true; }
           
            else return false;
        }
    }
}
