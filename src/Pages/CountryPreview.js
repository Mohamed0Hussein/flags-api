import {useEffect} from 'react'
import { useLocation } from 'react-router-dom'
import { useAppContext } from '../context/appContext'
import { NavBar } from '../Components'
import { CountryContainer } from '../Components'
const CountryPreview = () => {

    const {currentCountry,fetchById,darkMode} = useAppContext()
    const {id} = useLocation().state
    useEffect(()=>{
        fetchById(id)
    },[])

  return (
    <div className={`h-screen ${darkMode ? `bg-[#2b3743]` : ``}`}>
    <NavBar/>
    <CountryContainer country={currentCountry}/>
    </div>
  )
}

export default CountryPreview