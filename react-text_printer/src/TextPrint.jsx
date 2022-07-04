import React, { useState }  from "react";
import "./TextPrint.css"
export const PrintText=()=>{
    const[text,setText]=useState("");
       

return(

<div>
    <label> Please Enter Text :</label><br></br>
  
    <textarea value={text} onChange={(e)=>setText(e.target.value)}></textarea>
  
<br></br>

    <div>Entered Text is :<br></br><p> {text}</p></div>
    </div>
);
}