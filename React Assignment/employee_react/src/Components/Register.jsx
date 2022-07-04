/*  Create a Register component and Records component.
    Register component should have a registration form for employee.
    When form is submitted it should call your web api http post method.
    The response of above api call must be displayed in Records component. 
    Records component should be a table of all employees created using form.      */

    import React, { useState }  from "react";

export const RegisterEmployee=()=>
    {
        const [inputField , setInputField] = useState({
            name: '',
            city: '',
            salary: ''
        })
    
        const inputsHandler = (e) =>{
            setInputField( {[e.target.name]: e.target.value} )
        }
    
        const submitButton = () =>{
            alert("Submitted")
        }
        

        const url=""

 return(
    <div>

    <input type="text"  name="first_name" onChange={inputsHandler} placeholder="Name" value={inputField.name}/>    <br/>

    <input type="text" name="city" onChange={inputsHandler} placeholder="City" value={inputField.city}/>    <br/>

    <input type="text" name="salary" onChange={inputsHandler} placeholder="Salary" value={inputField.salary}/>   <br/>

    <button onClick={submitButton}>Submit </button>

    </div>

    );
}