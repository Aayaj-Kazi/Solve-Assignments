using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);

        Employee GetEmployeeByID(int id);

        IEnumerable<Employee> GetAllEmployee();

        Employee GetHighestSalaryByCity(string city);

        IEnumerable<Employee> GetEmployeesWithoutID(string name,string city);

    }
    public class EmployeeService : IEmployeeService
    {
        List<Employee> _listEmployees=new List<Employee> { 
        new Employee { Id=1, Name="Tony", City="Pune", Salary=10000},
        new Employee { Id=2, Name="Steve", City="Mumbai", Salary=20000},
        new Employee { Id=3, Name="Thor", City="Solapur", Salary=30000},
        new Employee { Id=4, Name="Barton", City="Thane", Salary=20000},
        new Employee { Id=5, Name="Bruce", City="Ahamadnagar", Salary=10000},
        new Employee { Id=6, Name="Natasha", City="Pune", Salary=12000},
            };

        public void AddEmployee(Employee employee)
        {
            _listEmployees.Add(employee);
           
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
           
            return _listEmployees;
        }

        public Employee GetEmployeeByID(int id)
        {
          
            var employeeByID = _listEmployees.FirstOrDefault(e => e.Id == id);
            return employeeByID;
        }

        public Employee GetHighestSalaryByCity(string city)
        {
            var employeeHighSalaryByCity = _listEmployees.Where(e => e.City == city).OrderByDescending(em => em.Salary).First(); 
            return employeeHighSalaryByCity;
            
        }

        public IEnumerable<Employee> GetEmployeesWithoutID(string name, string city)
        {
            var employeeWithoutId = _listEmployees.Where(e => e.City == city).ToList();
            return employeeWithoutId;
        }
    }
}


