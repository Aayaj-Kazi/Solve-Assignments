import React, { Component } from 'react';
import  axios from "axios";

export default class AddUserComponent extends Component {
        constructor(props){
            super(props)
    
            this.state = {
                id:7,
                name:'',
                city:'', 
                salary:12345
            }
                
    
        }
        changeIdHandler =(event) => {this.setState(
            {id:event.target.value} 
          )};
    
        changeNameHandler =(event) => {this.setState(
          {name:event.target.value} 
        )};
    
          changeCityHandler =(event) => {this.setState(
            {city:event.target.value} 
          )};
    
          changeSalaryHandler =(event) => {this.setState(
            {salary:event.target.value} 
          )};
    
          addUser = (e) => {e.preventDefault();
          let employee = {id: this.state.id,
            name: this.state.name,
            city: this.state.city,
            salary: this.state.salary,
                        
                    };
                          console.log(employee);
    
                          axios.post('https://localhost:44379/Employee/AddEmployee', employee);;
          }
    
         
          
    
    
        render() {
            return (
                <div>
                  <div className="container">
                      <div className="row">
                          <div className="card col-md-6 offset-md-3 offset-md-3">
                              <h2 className="text-center">Registration</h2>
                              
                              <div className="card-body">
                                  <form>
                                      <div className="form-group">
                                          <label>ID</label>
                                          <input placeholder='Id' name='id' className='form-control' value={this.state.id} onChange={this.changeIdHandler} required></input><br/>
                                          <label>Name</label>
                                          <input placeholder='Name' name='name' className='form-control' value={this.state.name} onChange={this.changeNameHandler}></input><br/>
                                          <label>City</label>
                                          <input placeholder='City' name='city' className='form-control' value={this.state.city} onChange={this.changeCityHandler}></input><br/>
                                          <label>Salary</label>
                                          <input placeholder='Salary' name='salary' className='form-control' value={this.state.salary} onChange={this.changeSalaryHandler}></input><br/>
                                         <button className="btn btn-success" onClick={this.addUser}>Submit</button>
                                          
                                      </div>
                                  </form> 
                              </div>
                        </div> 
                      </div>
                  </div>
                    
                </div>
            );
        }
    }
    
    