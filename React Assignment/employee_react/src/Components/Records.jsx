import React, { useState }  from "react";
import { useEffect } from "react";
import  axios from "axios";

export const ShowRecord=()=>{
   const[inform,getInform]=useState("");
   
    const GetAllEmployeeDetails=()=>{
        
        axios.get('https://localhost:44379/Employee/GetAllEmployee')
        .then((response)=>{
            const getInfo=response.data;
            console.log(response.data);
           getInform(getInfo);
        });
      }

      useEffect(()=>{
        GetAllEmployeeDetails();
       },[]);

     

return(
<div>
    <table>{inform.employee.map(emp =>
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
  
</div>
);
}