import React, { useEffect, useState } from "react";
import axios from "axios";
import { Quotes, Security } from "./Security&Quote";
import '../CSS/SecurityComponent.css'
import dateFormat from 'dateformat';

export const SecurityList = () => {
  const [security, setSecurity] = useState(null);
  const [quotes, setQuotes] = useState(null);
  const [select, setSelect] = useState(null);

  const scrollPos=()=>{
    var rightScrollPos = document.getElementById("table-scroll-tasks1").scrollTop;
    document.getElementById("table-scroll-employees1").scrollTop = rightScrollPos; 

    var rightScrollPos = document.getElementById("table-scroll-tasks2").scrollTop;
    document.getElementById("table-scroll-employees2").scrollTop = rightScrollPos; };

  useEffect(() => {
    axios
      .get("https://localhost:44373/Securities/GetAllSecurities")
      .then((response) => {
       //console.log(response.data);
        var security = [];
        response.data.map((x) => {
          security.push(
            new Security(
              x.securityID,
              x.identifier,
              x.securityName,
              x.assetClass,
              x.quotesCount
            )
          );
        });
        //console.log(security);
        setSecurity(security);
      })
      .catch(function (error) {
        console.log(error.toJSON());
      });



      axios
      .get('https://localhost:44373/Securities/GetQuotesBySecurityId/'+1)
      .then((response) => {
        //console.log(response.data);
        var quote = [];
        response.data.map((x) => {
          quote.push(
            new Quotes(x.quoteID, x.date, x.quotesAmt,x.provider, x.quoteType, x.securityID)
          );
        });
        setQuotes(quote);
         setSelect(1);
            });


  },[]);

  const GetAllQuotes =(securityID) => {
    
    axios
      .get('https://localhost:44373/Securities/GetQuotesBySecurityId/'+securityID)
      .then((response) => {
        //console.log(response.data);
        var quote = [];
        response.data.map((x) => {
          quote.push(
            new Quotes(x.quoteID, x.date, x.quotesAmt,x.provider, x.quoteType, x.securityID)
          );
        });
        setQuotes(quote);
        setSelect(securityID);
       //console.log(quote);
      })
      .catch(function (error) {
        console.log(error.toJSON());
      });
  };

  return (
    <div>
      <div>
       <h2>Security</h2>
       <div id="table-scroll-tasks1" onChange={()=>scrollPos()}>
        <table className="security">
          <tbody>
            <tr>
              <th> Identifier </th>
              <th> Security Name </th>
              <th> Asset Class </th>
              <th> Quotes</th>
            </tr>
            {security &&
              security.map((sec) => (
                
                <tr key={sec.securityID} onClick={()=>GetAllQuotes(sec.securityID)} className={select === sec.securityID && "table-row"}>
                <td>{sec.identifier}</td>
                <td>{sec.securityName}</td>
                <td>{sec.assetClass}</td>
                <td>{sec.quotesCount}</td>
              </tr>
                
              ))}
          </tbody>
        </table>
        </div>
      </div>

      <div>
      <h2>Quotes</h2>
      <div id="table-scroll-tasks2" onscroll="scrollPos()">
      <table className="quotes">
        <tbody>
          <tr>
             
              <th> Date </th>
              <th> Quotes </th>
              <th> Provider </th>
              <th> Quote Type</th>
          </tr>
          {quotes &&
            quotes.map((quot) => (
                <tr key={quot.quoteID} >
                
                <td>{dateFormat(quot.date,"mm-dd-yyyy")}</td>
                <td>{quot.quotesAmt}</td>
                <td>{quot.provider}</td>
                <td>{quot.quoteType}</td>
                </tr>
            ))}
        </tbody>
      </table>
      </div>
      </div>
    </div>
  );
};
