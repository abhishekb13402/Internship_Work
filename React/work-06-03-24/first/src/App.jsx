import React from 'react'
import "./App.css"

const user={
  name:'Abhishek Bhatt',
  imageUrl:'/src/img/user.jpg',
  imageSize: 90,
};



function MyButton(){
  function handleClick(){
    alert('Hellooo');
  }
  return (
    <button onClick={handleClick}>Submit</button>
  );
}

function AboutPage(){
  return(
    <>
      <h1>About</h1>
      <p>Hello</p>
    </>
  );
}

function Cardbox(){
  return(
    <>
      <h1>{user.name}</h1>
      <img
          className="avatar"
          src={user.imageUrl}
         alt={'Photo of ' + user.name}
         style={{
           width: user.imageSize,
           height: user.imageSize
           
         }}
      />
    
    </>
  );
}

const App = () => {
  return (
    <div>
      <AboutPage/>
      <h1>Welcome</h1>
      <MyButton/>
      <Cardbox/>
    </div>




  )
}

export default App
