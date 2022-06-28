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
           
            Task t1 = Task.Factory.StartNew(() => {
                PeopleCounterSystem countPeople = PeopleCounterSystem.getInstance;
                if (countPeople.ValidPerson(1))
                { Console.WriteLine("Welcome 111111111111111111!!"); }
                else
                {
                    Console.WriteLine("Not Allowed");
                }
            });

            Task t2= Task.Factory.StartNew(() => {
                PeopleCounterSystem countPeople2= PeopleCounterSystem.getInstance;
                if (countPeople2.ValidPerson(2))
                { Console.WriteLine("Welcome 22222222222222222!!"); }
                else
                {
                    Console.WriteLine("Not Allowed");
                }
            });

            Task.WaitAll(t1, t2);


            //DriveTrain newLocoDriver = DriveTrain.getInstance;
            //if (newLocoDriver.Drive("backward"))
            //{
            //    Console.WriteLine("Train is moving!!");
            //}
            //else
            //{
            //    Console.WriteLine("Train is Stopped!!");
            //}

            // //With lock
            // DriveTrain locoDriver = DriveTrain.getInstance;
            //if (locoDriver.Drive("forward"))
            // {
            //     Console.WriteLine("Train is moving!!");
            // }
            //else
            // {
            //     Console.WriteLine("Train is Stopped!!");
            // }




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
