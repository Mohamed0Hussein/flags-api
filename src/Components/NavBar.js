import React from 'react'
import {FaMoon} from 'react-icons/fa'
import { useAppContext } from '../context/appContext'
const NavBar = () => {
  const {toggleDarkMode,darkMode} = useAppContext()
  return (
    <div className={`w-full py-7 flex justify-between shadow-md mb-12 ${darkMode ? `bg-[#2b3743] text-white`:``}`}>
        <h1 className='text-2xl font-bold ml-10'>Where in the world?</h1>
        <div className='flex flex-row text hover:cursor-pointer' onClick={toggleDarkMode}>
          <div className='mr-10 flex flex-row'>
            <FaMoon className='text-xl mr-2 mt-1'/>
            <p>{!darkMode ? 'Dark' : 'Light'} mode</p>
          </div>
        </div>
    </div>
  )
}

export default NavBar