import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route,  Switch} from 'react-router-dom';
import { SecurityList } from './Component/SecurityComponent';


function App() {
  return (
    <div className="App">
     <Router>
      <Switch>
        <Route path='/' exact component={SecurityList}></Route>
      </Switch>
     </Router>
    </div>
  );
}

export default App;
