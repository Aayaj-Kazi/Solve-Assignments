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
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Document</title>
    
</head>
<body>
    <label> Please Enter Text :</label><br></br>
  
    <textarea value={state} onChange={(e)=>setState(e.target.value)}></textarea>
  
<br></br>

    <div>Entered Text is :<br></br><p> {state}</p></div>
</body>
</html>
);
}