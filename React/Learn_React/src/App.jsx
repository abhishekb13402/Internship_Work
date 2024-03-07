import React from 'react'
import "./App.css"
import {useState} from 'react'
// import Counter_separately from './components/counters/Counter_separately'

const App = () => {
  return (
    <div>

      <h1>Counters that update separately</h1>
      <MyButton/>
      <MyButton/>

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
