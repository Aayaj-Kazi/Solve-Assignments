using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public abstract class Students
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public int FindAverage(int marks, int subjects)
        {
            return marks / subjects;
        }

        public abstract string Result(int average, int required);
    }
}
