import React from 'react'
import Navbar from './components/Navbar'
import Home from './components/Home'
import {useState} from 'react'
// import Counter_separately from './components/counters/Counter_separately'

const App = () => {
  return (
    <div>

      <Navbar/>
      <div className="content">
        <Home/>
      </div>
      <hr/>
      
      <h1>Counters that update separately</h1>
      <MyButton/>
      <MyButton/>
      <hr/>


      <hr/>

      

      {/* <h2>React</h2>
      <table>
        <tr>
          <th>No.</th>
          <th>Title</th>
          <th>Path</th>
        </tr>
        <tr>
          <td>1.</td>
          <td>Counters Separately</td>
          <td> </td>
        </tr>
      </table> */}
    </div>
  )
}

function MyButton(){
  const [count,setCount] = useState(0);

  function handleClick(){
    setCount(count+1);
  }

  return(
    <button onClick={handleClick}>
      Clicked {count} times
    </button>
  );

}

export default App
