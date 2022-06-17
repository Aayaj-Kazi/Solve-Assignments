using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    //1. Create an employee class with properties (Id, Name, City, Salary).
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }    
        public double Salary { get; set; }

        public static void Main(string[] args)
        {
            //2. Create List of Employees with hardcodes employes(100 entries, Id 1 to 100)

           // Employee employee = new Employee();

            List<Employee> empList = new List<Employee>();
            
            for (int i = 1; i < 101; i++)
            {
                empList.Add(new Employee()
                    {
                        Id = i,
                        Name = "  Employee" + i,
                        City = "  City" + i,
                        Salary = 10000+i

                    });
                }

           



            //3. Write a Linq query to find employee with an id 45
            var empID = empList.Where(e => e.Id == 45);
            
            foreach (Employee emp in empID)
            {
                Console.WriteLine("ID:"+emp.Id+" Name:"+emp.Name+" City:"+emp.City+" Salary:"+emp.Salary);
            }
            Console.WriteLine();

            //4.Write a Linq query to find employees with an id that are even
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    var empEven = empList.Where(e => e.Id == i);
                    foreach (Employee emp in empEven)
                    {
                        Console.WriteLine("ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
                    }
                }
            }
            Console.WriteLine();





            //5. Write a Linq query to find highest salary holder
            var highest=empList.Max(e => e.Salary);
            Console.WriteLine("Max Salary is :" + highest);
            Console.WriteLine();




            //6. Write a Linq query to find highest salary holder in Pune City
            // there is no city as Pune in employee list therefor City25 
            var highSalaryCity = empList.Where(emp => emp.City == "City1").GroupBy(e => e.City)
                    .Select(em => em.OrderByDescending(e => e.Salary).First());
           
            Console.WriteLine("Max Salary in Pune// City 25 :" + highSalaryCity);
            foreach (Employee emp in highSalaryCity)
            {
                Console.WriteLine("ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
            }
            Console.WriteLine();

            




            //7. Write a Linq query to find highest salary holder from each city
            
            var highSalEachCity = empList.GroupBy(e => e.City)
                 .Select(em => em.OrderByDescending(e => e.Salary).First());
            
            foreach (Employee emp in highSalEachCity)
            {
                Console.WriteLine("ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
            }
        }
    }
}
