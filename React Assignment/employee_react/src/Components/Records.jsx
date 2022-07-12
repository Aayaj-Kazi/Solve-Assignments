import React, { useState }  from "react";
import  axios from "axios";
import { Link } from "react-router-dom";
import '../Styles/Records.css'
import { Employee } from "./Employee";



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
           
        }).catch(function (error) {
          console.log(error.toJSON())});
      }
      
     
     

return(
  <div>
<div>

<Link to="/AddEmployee"> Add New Employee</Link> <br></br>
    <button className="showBTN" onClick={GetAllEmployeeDetails}> Show All Employee </button>
   
    <table className="Table">

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
   
   
  
</div>





</div>
);
}