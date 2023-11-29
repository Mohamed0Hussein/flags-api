import React from 'react'
import { useAppContext } from '../context/appContext'
import BackBar from './BackBar'
const CountryContainer = () => {
    const {currentCountry,darkMode} = useAppContext()
  return (
    <div className={`${darkMode ? `bg-[#2b3743] text-white` : ``}`}>
        <BackBar/>
        <div className={darkMode? `bg-[#2b3743] text-white` : ``}>
            <div className='mx-24 my-10 flex flex-row'>
                <img src={currentCountry.svg} className='w-auto h-96'/>
                <div className='flex flex-col'>

                <div className='flex flex-row'>

                    <div className='flex flex-col ml-20 pt-12 '>
                        <p className='text-2xl font-bold mb-5'>{currentCountry.name}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Native name :</span> {currentCountry?.nativeName}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Population :</span> {currentCountry.population?.toLocaleString()}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Region :</span> {currentCountry?.region}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Subregion :</span> {currentCountry?.subregion}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Capital :</span> {currentCountry?.capital}</p>
                    </div>
                    <div className='flex flex-col ml-20 mt-24'>
                        <p className='my-2'><span className='font-bold text-sm'>Top Level Domain :</span> {currentCountry.topLevelDomain?.map(tld => {return (`${tld.name} `)})}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Currencies :</span> {currentCountry.currencies?.map(cur => cur.name).join(', ')}</p>
                        <p className='my-2'><span className='font-bold text-sm'>Languages :</span> {currentCountry.languages?.map(cur => cur.name).join(', ')}</p>
                    </div>
                </div>
                <div className='ml-20 mt-10'>
                    <span className='font-bold'>Border Countries :</span> {currentCountry.bordersCountries?.map(br => {
                        return <button className={`mx-1 py-1 px-3 shadow-md rounded-lg ${darkMode ? `bg-[#202d36] shadow-black` : `bg-slate-100`} `}>{br}</button>
                    })}
                </div>
                </div>
            </div>
        </div>
    </div>
  )
}

export default CountryContainer