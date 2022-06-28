using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesignUpdated
{
    internal class PeopleCounterSystem
    {
        public int Id{ get; set; }

        private static  int count = 0;
        private PeopleCounterSystem()
        {
            count++;
            Console.WriteLine("Number of People entered  " + count);

        }
        
        private static PeopleCounterSystem instance;
        private static readonly object Obj = new object();
        public static PeopleCounterSystem getInstance
        {
            get
            {
                    lock (Obj)
                    {
                        if (instance == null)
                            instance = new PeopleCounterSystem();
                    }
                PeopleCounterSystem.count++;
                Console.WriteLine("Number of People entered " + count);
                return instance;
            }
        }

        public bool ValidPerson(int id)
        {
            if (id > 0)
            { return true; }

            else return false;
        }
    }
}

