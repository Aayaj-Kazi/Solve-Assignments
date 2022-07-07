import React, { useState }  from "react";
import  axios from "axios";
import { Link } from "react-router-dom";


class Employee {
    constructor( id,name,city,salary) {
      this.id = id;
      this.name = name;
     this.city = city;
     this.salary=salary
    }
  }

export const ShowRecord=()=>{
   const[employees,setEmployees]=useState(null);
   
   
    const GetAllEmployeeDetails=()=>{
        
        axios.get('https://localhost:44379/Employee/GetAllEmployee')
        .then((response)=>{
         
            var employees = [];
            response.data.map(x=> {
                employees.push(new Employee( x.id,x.name, x.city, x.salary  ))
            });
            setEmployees(employees);
           
        });
      }
      
     
     

return(
<div>
{/* <button onClick={GetAllEmployeeDetails}> Add New Employee </button> */}
<Link to="/AddEmlployee"> Add New Employee</Link>
    <button onClick={GetAllEmployeeDetails}> Show All Employee </button>
   
    <table >

          <tbody>
            <tr>
              <th> Employee Id </th>
              <th> Employee Name </th>
              <th> Employee City </th>
              <th> Employee Salary</th>
            </tr>
        {
          employees &&
          employees.map(emp =>
              <tr>
                <td>{emp.id}</td>
                <td>{emp.name}</td>
                <td>{emp.city}</td>
                <td>{emp.salary}</td>
              </tr>
        )}
       </tbody>
    </table>
    <Link to="/AddEmployeeUsingClassComponent"> Add New Employee Using Class Component</Link>
   
  
</div>
);
}