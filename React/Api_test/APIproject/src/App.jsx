import React, { useState, useEffect } from 'react';
import axios from axios;
function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      // const response = await fetch('https://jsonplaceholder.typicode.com/users');
      const response = await fetch('https://localhost:7244/api/RegisterUser');
      const jsonData = await response.json();
      setData(jsonData);
    }
    fetchData();
  }, []);

  return (
    <div>
      <h1>List of Users</h1>
      <ul>
        {data.map(user => (
          <li key={user.Id}>
            {user.Username} ({user.UserPassword})
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;