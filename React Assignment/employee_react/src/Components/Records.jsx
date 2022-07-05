import React, { useState }  from "react";
import { useEffect } from "react";
import  axios from "axios";

class Employee {
    constructor( id,name,city) {
      this.id = id;
      this.name = name;
     this.city = city;
    }
  }

export const ShowRecord=()=>{
   const[employees,setEmployees]=useState(null);

   
    const GetAllEmployeeDetails=()=>{
        
        axios.get('https://localhost:44379/Employee/GetAllEmployee')
        .then((response)=>{
            const info=response.data;
            setEmployees(info);
            //console.log(response.data);
            // getDetails(info);
            var employees = [];
            response.data.map(x=> {
                employees.push(new Employee( x.id,x.name, x.city))
            });
            setEmployees(employees);
            console.log(employees);
        });
      }
      //console.log(details); 
      useEffect(()=>{
        GetAllEmployeeDetails();
       },[]);

     

return(
<div>
    <button> Add New Employee </button>
   
    {/* <table>{employees.map(emp =>
        <tbody>
       <tr key={emp.id}>
        <th> Employee Id </th>
        <th> Employee Name </th>
        <th> Employee City </th>
       </tr>
       <tr>
       <td>{emp.Id}</td>
      <td>{emp.Name}</td>
      <td>{emp.City}</td>
       </tr>
       </tbody>
       )}
    </table> */}
  
</div>
);
}