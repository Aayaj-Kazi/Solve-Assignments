
    import React, { useState }  from "react";
    import  axios from "axios";
    import { useHistory } from "react-router-dom";
    import '../Styles/Register.css'
export const RegisterEmployee=()=>
    {

        class Employee {
            
            constructor(id,name,city,salary) {
              this.id = id+1;
              this.name = name;
             this.city = city;
             this.salary=salary
            }
          }
        
          const history = useHistory();
        const [empId , setEmpId] = useState(6);
        const [empName , setEmpName] = useState('');
        const [empCity , setEmpCity] = useState('');
        const [empSalary , setEmpSalary] = useState(0);
     
        const SaveEmployee=(x)=>{
            setEmpId(empId + 1);
                var IdEmp=parseInt(empId);
                var SalaryEmp=parseInt(empSalary);

                if(empName === '')
                {
                    alert("Name Field cannot be Empty!!!!")
                }
                
                if(empCity === '')
                {
                    alert("City Field cannot be Empty!!!!")
                }
                

                if(SalaryEmp <= 0)
            {
                alert("Salary Field cannot be Empty!!!!")
            }
            else
            { const employee=new Employee(IdEmp,empName,empCity,SalaryEmp);
         
           // console.log(employee);
            axios.post('https://localhost:44379/Employee/AddEmployee', employee);
            let path = '/'; 
             history.push(path);
            }
        }


      
 return(<div>
    <div className="RegisterForm">

    <input type="text"  name="name" onChange={(e)=>setEmpName(e.target.value)} placeholder="Name" value={empName} required/>    <br/>

    <input type="text" name="city" onChange={(e)=>setEmpCity(e.target.value)} placeholder="City" value={empCity} required/>    <br/>

    <input type="number" name="salary" onChange={(e)=>setEmpSalary(e.target.value)} placeholder="Salary" value={empSalary} required/>   <br/>

    <button onClick={()=>SaveEmployee()}>Submit </button>

    </div>
    </div>
    );
}