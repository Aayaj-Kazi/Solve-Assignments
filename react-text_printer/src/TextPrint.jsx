import React, { useState }  from "react";
import "./TextPrint.css"
export const PrintText=()=>{
    const[state,setState]=useState("");

    // const saveText=()=>{
    //     let text = document.querySelector('#textInput').value.trim();
      
    //     console.log(text);
    //     setState(text);
    //     };
    //don't use set use effect somthing
       

return(
// <!DOCTYPE html>
<div>
    <label> Please Enter Text :</label><br></br>
  
    <textarea value={state} onChange={(e)=>setState(e.target.value)}></textarea>
  
<br></br>

    <div>Entered Text is :<br></br><p> {state}</p></div>
    </div>
);
}