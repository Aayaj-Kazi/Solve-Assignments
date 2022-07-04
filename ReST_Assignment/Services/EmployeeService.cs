using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee.Service
{
    public interface IEmployeeService
    {
        void AddEmployee(Employees employee);

        Employees GetEmployeeByID(int id);

        List<Employees> GetAllEmployee();

        dynamic GetHighestSalaryByCity(string city);

        List<Employees> GetEmployeesWithoutID(string name,string city);

    }
    public class EmployeeService : IEmployeeService
    {
        List<Employees> _listEmployees=new List<Employees> { 
        new Employees {Id=1, Name="Tony",City="Pune", Salary=10000},
        new Employees {Id=2, Name="Steve",City="Mumbai", Salary=20000},
        new Employees {Id=3, Name="Thor",City="Solapur", Salary=30000},
        new Employees {Id=4, Name="Barton",City="Thane", Salary=20000},
        new Employees {Id=5, Name="Bruce",City="Ahamadnagar", Salary=10000},
        new Employees {Id=6, Name="Natasha",City="Pune", Salary=12000},
            };

        public void AddEmployee(Employees employee)
        {
            _listEmployees.Add(employee);
           
        }

        public List<Employees> GetAllEmployee()
        {
           
            return _listEmployees;
        }

        public Employees GetEmployeeByID(int id)
        {
            //var EmployeeByID=_listEmployees[id];
            var EmployeeByID = _listEmployees.FirstOrDefault(e => e.Id == id);
            return EmployeeByID;
        }

        public dynamic GetHighestSalaryByCity(string city)
        {
            var employeeHighSalaryByCity = _listEmployees.Where(e => e.City == city).OrderByDescending(em => em.Salary).First(); 
            return employeeHighSalaryByCity;
            
        }

        public List<Employees> GetEmployeesWithoutID(string name, string city)
        {
            var employeeWithoutId = _listEmployees.Where(e => e.City == city).ToList();
            return employeeWithoutId;
        }
    }
}

//"1. Create a Web API project in .net core
//2.Create an api controller ""Employee""  
//3. Create an http get endpoint to return an employee by id
//4. Create an http get endpoint to return all employees
//5. Create an http get endpoint to return highest salary holder by city
//6. Create an http post endpoint that accepts employee, without an id, and returns an employee with Id filled. "
