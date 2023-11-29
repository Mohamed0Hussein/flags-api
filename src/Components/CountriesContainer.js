import React, { useEffect } from 'react'
import CountryCard from './CountryCard'
import { useAppContext } from '../context/appContext'
import MoonLoader from 'react-spinners/MoonLoader'
const CountriesContainer = () => {
    const {fetch,currentCountries,isLoading,region,page,name,darkMode} = useAppContext()
    useEffect(() => {
        fetch()
    },[region,page,name])
  return (
    <div className={`flex justify-center items-center mt-10 ${darkMode ? `bg-[#202d36] text-white` : ``}`}>

        {isLoading ? <MoonLoader/>: <div className='grid gap-52 grid-cols-4 '>           
            {currentCountries.map(country => {
                return(
                    <CountryCard key={country.id} imgSrc={country.flag.svg} name={country.name} population={country.population} region={country.region} capital={country.capital} id={country.id} demonym={country.demonym}/>
                    )
                })
            }
        </div>
        }
    </div>
  )
}

export default CountriesContainer