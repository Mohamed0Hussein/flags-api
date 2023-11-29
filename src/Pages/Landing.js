import React from 'react'
import {CountriesContainer, NavBar, SearchContainer} from '../Components'
import { useAppContext } from '../context/appContext'
const Landing = () => {
  const {darkMode} = useAppContext()
  return (
    <div className={darkMode ? `bg-[#202d36]` : ``}>
        <NavBar/>
        <SearchContainer/>
        <CountriesContainer/>
    </div>
  )
}

export default Landing