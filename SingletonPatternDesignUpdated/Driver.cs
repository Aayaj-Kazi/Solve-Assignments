using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDesignUpdated
{
    internal class Driver
    {
        public static void Main(string[] args)
        {
            //With lock
            DriveTrain locoDriver = DriveTrain.getInstance;
           if (locoDriver.Drive("forward"))
            {
                Console.WriteLine("Train is moving!!");
            }
           else
            {
                Console.WriteLine("Train is Stopped!!");
            }


            DriveTrain newLocoDriver = DriveTrain.getInstance;
            if (newLocoDriver.Drive("backward"))
            {
                Console.WriteLine("Train is moving!!");
            }
            else
            {
                Console.WriteLine("Train is Stopped!!");
            }





            //WithOut Lock
            BlowHorn pressButton = BlowHorn.getInstance;
            
            if (pressButton.IsPressed("pressed"))
            {
                Console.WriteLine("Horn!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }


            //BlowHorn pressButtonHard = BlowHorn.getInstance;
            //if (pressButtonHard.isPressed("pressed"))
            //{
            //    Console.WriteLine("HORNNNNNNNNNNNNN!!!");
            //}
        }
    }
}
