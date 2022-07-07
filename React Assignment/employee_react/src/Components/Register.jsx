
    import React, { useState }  from "react";
    import  axios from "axios";

export const RegisterEmployee=()=>
    {

        // class Employee {
        //     constructor( id,name,city,salary) {
        //       this.id = id;
        //       this.name = name;
        //      this.city = city;
        //      this.salary=salary
        //     }
        //   }
        
         //const[employees,setEmployees]=useState();
        const [empId , setEmpId] = useState();
        const [empName , setEmpName] = useState();
        const [empCity , setEmpCity] = useState();
        const [empSalary , setEmpSalary] = useState();
               
        const SaveEmployee=(x)=>{
            
             const employee={
                id:empId,
                ename:empName,
                city:empCity, 
                salary:empSalary
            }
           // setEmployees(employees);
            console.log(employee);
            axios.post('https://localhost:44379/Employee/AddEmployee', employee);
            
        }

      
 return(
    <div>

    <input type="text"  name="id" onChange={(e)=>setEmpId(e.target.value)} placeholder="ID" value={empId}/>    <br/>

    <input type="text"  name="name" onChange={(e)=>setEmpName(e.target.value)} placeholder="Name" value={empName}/>    <br/>

    <input type="text" name="city" onChange={(e)=>setEmpCity(e.target.value)} placeholder="City" value={empCity}/>    <br/>

    <input type="text" name="salary" onChange={(e)=>setEmpSalary(e.target.value)} placeholder="Salary" value={empSalary}/>   <br/>

    <button onClick={()=>SaveEmployee()}>Submit </button>

    </div>

    );
}