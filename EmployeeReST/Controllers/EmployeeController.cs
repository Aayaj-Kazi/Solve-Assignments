using Employee.Models;
using Employee.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Employee.Controllers
{
    [ApiController]
    [Route("[controller]")]   //same as [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployee")]
        public IEnumerable<Employees> PrintAllEmployee()
        {

          
           return _employeeService.GetAllEmployee();
           
        }
    }
}
