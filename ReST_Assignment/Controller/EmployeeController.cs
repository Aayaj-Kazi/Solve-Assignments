using Employee.Models;
using Employee.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Employee.Controllers
{
    [ApiController]
    [Route("[controller]")] //same as [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAllEmployee")] 
        public IActionResult PrintAllEmployee()
        {
           return Ok(_employeeService.GetAllEmployee());
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_employeeService.GetEmployeeByID(id));
        }

        [HttpGet]
        [Route("GetHighestSalaryByCity/{city}")]
        public IActionResult GetEmployeeById(string city)
        {
            return Ok(_employeeService.GetHighestSalaryByCity(city));
        }


        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployeeWithoutId(Employees employee )
        {
             _employeeService.AddEmployee(employee);
        }

        //public IActionResult AddEmployeeWithoutId(Employees employee)
        //{
        //    return Ok(_employeeService.AddEmployee(employee);
        //}

    }
}
