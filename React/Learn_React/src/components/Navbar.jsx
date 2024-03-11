import React from 'react'

const Navbar = () => {
  return (
      <nav className='navbar'>
        <h1>EduHub</h1>
        <div className="links">
            <a href="/">Home</a>
            <a href="/create">New app</a>
        </div>
      </nav>
  )
}

export default Navbar
