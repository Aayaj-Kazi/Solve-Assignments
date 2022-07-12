
    import React, { useState }  from "react";
    import  axios from "axios";
    import { useHistory } from "react-router-dom";
    import '../Styles/Register.css'
    import { Employee } from "./Employee";


export const RegisterEmployee=()=>
    {

        
          const history = useHistory();
        const [empId , setEmpId] = useState(7);
        const [empName , setEmpName] = useState('');
        const [empCity , setEmpCity] = useState('');
        const [empSalary , setEmpSalary] = useState(Number);

        const [nameError , setNameError] = useState('');
        const [cityError , setCityError] = useState('');
        const [salaryError , setSalaryError] = useState('');


        const SaveEmployee=(x)=>{
            setEmpId(empId + 1);
                var IdEmp=parseInt(empId);
                var SalaryEmp=parseFloat(empSalary);

                if(empName === '')
                {setNameError("Please Enter Name!!")}
                
                 if(empCity === '')
                {setCityError("Please Enter City Name!!")}
                

                 if(SalaryEmp < 1)
                {setSalaryError("Salary cannot be 0")}

                if(!(SalaryEmp < 1) && !(empCity === '')  && !(empName === ''))
            { const employee=new Employee(IdEmp,empName,empCity,SalaryEmp);
         
           // console.log(employee);
            axios.post('https://localhost:44379/Employee/AddEmployee', employee).catch(function (error) {
                console.log(error.toJSON())});
            let path = '/'; 
             history.push(path);
            }
        }


      
 return(<div>
    <div className="RegisterForm">


    <input type="text"  name="name" onChange={(e)=>setEmpName(e.target.value)} placeholder="Name" value={empName} required/>    <span style={{fontSize:10,color:"Red"}}>{nameError}</span>  <br/>

    <input type="text" name="city" onChange={(e)=>setEmpCity(e.target.value)} placeholder="City" value={empCity} required/>   <span style={{fontSize:10,color:"Red"}}>{cityError}</span>   <br/>

    <input type="text" name="salary" onChange={(e)=>setEmpSalary(e.target.value)} placeholder="Salary" value={empSalary} required/>  <span style={{fontSize:10,color:"Red"}}>{salaryError}</span> <br/>

    <button onClick={()=>SaveEmployee()}>Submit </button>

    </div>
    </div>
    );
}