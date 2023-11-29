import React from 'react'
import {Link} from 'react-router-dom'
import { useAppContext } from '../context/appContext'
const CountryCard = ({imgSrc,name,population,region,capital,id,demonym}) => {
  const {darkMode} = useAppContext()
  return (
    <div className={`flex flex-col shadow-lg w-content rounded-b-lg hover:cursor-pointer hover:shadow-2xl items-center ${darkMode ? `bg-[#2b3743]` : ``}`}>
      <Link to='/Country_Preview' state={{id}} >
        <img style={{width:'16rem', height:'11rem'}} src={imgSrc} className='rounded-t-lg' alt={`img of the ${demonym} flag`}/>
        <div className='mx-5 pt-5 mb-10 flex-wrap'>
            <p className='font-bold mb-4 '>{name}</p>
            <p className='text-xs my-2'><span className='font-bold'>Population</span> : {population.toLocaleString()}</p>
            <p className='text-xs my-2'><span className='font-bold'>Region</span> : {region}</p>
            <p className='text-xs my-2'><span className='font-bold'>Capital</span> : {capital}</p>
        </div>
      </Link>
    </div>
  )
}

export default CountryCard