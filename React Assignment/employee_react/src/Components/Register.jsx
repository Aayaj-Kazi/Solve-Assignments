/*  Create a Register component and Records component.
    Register component should have a registration form for employee.
    When form is submitted it should call your web api http post method.
    The response of above api call must be displayed in Records component. 
    Records component should be a table of all employees created using form.      */

    import React, { useState }  from "react";
    import  axios from "axios";

export const RegisterEmployee=()=>
    {
        const [inputField , setInputField] = useState({
            Id:9,
            name: '',
            city: '',
            salary: ''
        })
    
        const SavelEmployee=()=>{
        
            axios.post('https://localhost:44379/Employee/AddEmployee', inputField)
            .then(response => this.setInputField({ Id:response.data.name,
                 name: response.data.name,
            city: response.data.name,
            salary: response.data.name}));
            alert("Submitted")
          }

        const inputsHandler = (e) =>{
            setInputField( {[e.target.name]: e.target.value} )
        }
    
      
 return(
    <div>

    <input type="text"  name="name" onChange={inputsHandler} placeholder="Name" value={inputField.name}/>    <br/>

    <input type="text" name="city" onChange={inputsHandler} placeholder="City" value={inputField.city}/>    <br/>

    <input type="text" name="salary" onChange={inputsHandler} placeholder="Salary" value={inputField.salary}/>   <br/>

    <button onClick={()=>SavelEmployee()}>Submit </button>

    </div>

    );
}