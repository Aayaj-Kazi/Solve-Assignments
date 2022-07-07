import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route,  Switch} from 'react-router-dom';
import { ShowRecord } from './Components/Records';
import { RegisterEmployee } from './Components/Register';
import AddUserComponent from './Components/RegisterClassComponent';


function App() {
  return (
    <div className="App">
   <Router>
    <Switch>
      <Route path='/' exact component={ShowRecord}></Route>
      <Route path='/AddEmlployee'  component={RegisterEmployee}></Route>
      <Route path='/AddEmployeeUsingClassComponent' component={AddUserComponent}></Route>
      </Switch>
   </Router>

{/* <ShowRecord/> */}
{/* <RegisterEmployee/> */}
    </div>
  );
}

export default App;
