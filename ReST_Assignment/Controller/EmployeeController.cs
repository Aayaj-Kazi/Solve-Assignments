using Models;
using Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Controllers
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
        public IActionResult GetAllEmployee()
        {
           return Ok(_employeeService.GetAllEmployee());
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_employeeService.GetEmployeeByID(id));
        }

        [HttpGet]
        [Route("GetHighestSalaryByCity/{city}")]
        public IActionResult GetById(string city)
        {
            return Ok(_employeeService.GetHighestSalaryByCity(city));
        }


        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee(Employee employee )
        {
             _employeeService.AddEmployee(employee);
        }

        
    }
}
