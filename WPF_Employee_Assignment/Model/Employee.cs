using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Employee_Assignment.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public double Salary { get; set; }

        public string IsActive { get; set; }

    }
}
