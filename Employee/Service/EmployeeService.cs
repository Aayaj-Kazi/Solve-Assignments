using Employee.Models;

namespace Employee.Service
{
    public interface IEmployeeService
    {
        void AddEmployee(Employees employee);

        Employees GetEmployeeByID(int id);

        IEnumerable<Employees> GetAllEmployee();

        Employees GetEmployeesByCity(string city);

        Employees GetEmployeesWithoutID(string name,string city);

    }
    public class EmployeeService : IEmployeeService
    {
        List<Employees> _listEmployees=new List<Employees> { 
        new Employees {Id=1, Name="Tony",City="Pune", Salary=10000},
        new Employees {Id=2, Name="Steve",City="Mumbai", Salary=20000},
        new Employees {Id=3, Name="Thor",City="Solapur", Salary=30000},
        new Employees {Id=4, Name="Barton",City="Thane", Salary=20000},
        new Employees {Id=5, Name="Bruce",City="Ahamadnagar", Salary=10000},
        new Employees {Id=6, Name="Natasha",City="Pune", Salary=10000},
            };

        public void AddEmployee(Employees employee)
        {
            _listEmployees.Add(employee);
           
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return _listEmployees;
        }

        public Employees GetEmployeeByID(int id)
        {
            throw new NotImplementedException();
        }

        public Employees GetEmployeesByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Employees GetEmployeesWithoutID(string name, string city)
        {
            throw new NotImplementedException();
        }
    }
}

//"1. Create a Web API project in .net core
//2.Create an api controller ""Employee""  
//3. Create an http get endpoint to return an employee by id
//4. Create an http get endpoint to return all employees
//5. Create an http get endpoint to return highest salary holder by city
//6. Create an http post endpoint that accepts employee, without an id, and returns an employee with Id filled. "
