using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public  class Students
    {

        private int _ID;
        
        public void SetID ( int id)
        {
            if (id > 0)
            { _ID = id; }
            else
            {
                Console.WriteLine("Enter Valid ID!!");
            }

        }
        public int GetID()
        {
            return _ID;
        }

        private string _Name;
        public void SetName(string name)
        {
            if (name.Length > 4)
            {
                _Name = name;
            }
            else
            {
                Console.WriteLine("Characters Of Name Must be more then 4");
            }
        }
        public string GetName()
        {
            return _Name;
        }
    }
      
 }
        
        //public int FindAverage(int marks, int subjects)
        //{
        //    return marks / subjects;
        //}


       
    

