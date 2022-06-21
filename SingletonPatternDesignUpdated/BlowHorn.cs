using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesignUpdated
{
    sealed class BlowHorn
    {
        public string Horn { get; set; }


        private static BlowHorn instance;

        private int count = 0;
        private BlowHorn()
        {
            count++;
            Console.WriteLine("Object of BlowHorn " + count);
        }
        public static BlowHorn getInstance
        {
            get
            {  
                        if (instance == null)
                            instance = new BlowHorn();

                return instance;
            }
        }

        public bool IsPressed(string input)
        {
            if(input == "pressed")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public void ForObjectCount()
        {
            Console.WriteLine("object is created");
        }
    }
}
