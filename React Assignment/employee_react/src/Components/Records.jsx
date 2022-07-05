import React, { useState }  from "react";
import { useEffect } from "react";
import  axios from "axios";

const Employee


export const ShowRecord=()=>{
   const[details,getDetails]=useState(Employee);
   
    const GetAllEmployeeDetails=()=>{
        
        axios.get('https://localhost:44379/Employee/GetAllEmployee')
        .then((response)=>{
            const info=response.data;
            console.log(response.data);
            getDetails(info);
        });
      }
      console.log(details); 
      useEffect(()=>{
        GetAllEmployeeDetails();
       },[]);

     

return(
<div>
    <button> Add New Employee </button>

<table>{details.employee.map(emp =>
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
    </table> 










      {/* <table>
        <tbody>
       <tr >
        <th> Employee Id </th>
        <th> Employee Name </th>
        <th> Employee City </th>
       </tr>
       <tr>
       <td>{details.Id}</td>
      <td>{details.Name}</td>
      <td>{details.City}</td>
       </tr>
       </tbody>
       
    </table> */}


  
</div>
);
}