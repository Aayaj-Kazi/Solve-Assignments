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

            var empList = new List<Employee>();

            
            var cityList = new List<string> { "Pune", "Mumbai", "Ahmadnagar", "Nagpur","Akluj", "Latur","Delhi" };
           
            var random = new Random();
         
            for (int i = 1; i < 101; i++)
            {
                int index = random.Next(cityList.Count);
                empList.Add(new Employee()
                {
                    Id = i,
                    Name = "  Employee" + i,
                    City = cityList[index],
                    Salary = 10000 + i

                }); ;
                }





            //3. Write a Linq query to find employee with an id 45
            var empNumber = empList.Where(e => e.Id == 45);

            foreach (Employee emp in empList.Where(e => e.Id == 45))
            {
                Console.WriteLine(" Q3 ==> ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
            }
            Console.WriteLine();


            //4. Write a Linq query to find employees with an id that are even

            var empEven = empList.Where(e => e.Id%2 == 0);
           Console.WriteLine(" Q4 ==> ");
            foreach (Employee emp in empEven)
            {
                Console.WriteLine("ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
            }
            Console.WriteLine();





            //5. Write a Linq query to find highest salary holder
            var highestSalaryHolder = empList.OrderByDescending(e => e.Salary).First();
            Console.WriteLine(" Q5 ==> Max Salary is :" + highestSalaryHolder.Salary+"         Employee Name is :"+ highestSalaryHolder.Name);
           // Console.WriteLine($" Q5 ==> Max Salary is :{highest}");
            Console.WriteLine();




            //6. Write a Linq query to find highest salary holder in Pune City

            var highSalaryCity = empList.Where(emp => emp.City == "Pune").OrderByDescending(e => e.Salary).First();
          Console.WriteLine(" Q6 ==> Max Salary holder in Pune :- ID:" + highSalaryCity.Id + " Name:" + highSalaryCity.Name + 
              " City:" + highSalaryCity.City + " Salary:" + highSalaryCity.Salary);


           
            Console.WriteLine();

           
               



            //7. Write a Linq query to find highest salary holder from each city

            var highSalEachCity = empList.GroupBy(e => e.City)
                 .Select(em => em.OrderByDescending(e => e.Salary).First());
            
            foreach (var emp in highSalEachCity)
            {
                Console.WriteLine(" Q7 ==> ID:" + emp.Id + " Name:" + emp.Name + " City:" + emp.City + " Salary:" + emp.Salary);
            }
        }
    }
}
