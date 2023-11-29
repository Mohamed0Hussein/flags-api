import {SlMagnifier} from 'react-icons/sl'
import { useAppContext } from '../context/appContext'
const SearchContainer = () => {
    const {regionChanged,nameChanged,name,darkMode} = useAppContext()
  return (
    <div className={`flex justify-between items-center ${darkMode ? `bg-[#202d36] text-white` :``}`}>
        <div className={`m-3 p-2 shadow-md flex flex-row rounded-lg ml-10 w-96 ${darkMode ? `bg-[#2b3743] text-white` : ``}`}>
            <SlMagnifier className='my-2 mx-4 text-[#8a8a8a]' color={darkMode ? `white` : ``}/>
            <input className={`focus:outline-0  w-full ${darkMode ? `bg-[#2b3743] placeholder-white` : `text-[#464646]`}`} placeholder='Search for a country...' value={name} onChange={e => {nameChanged(e.target.value)}}/>
        </div>
        <div className='mr-10 shadow-md rounded-lg text-[#464646]'>
            <select className={`}border-none outline-0 px-2 py-3 rounded-lg ${darkMode ? `bg-[#2b3743] text-white` : ``}`} defaultValue={''} onChange={e => {regionChanged(e.target.value)}}>
                <option value=''>Filter by region</option>
                <option value='Asia'>Asia</option>
                <option value='Africa'>Africa</option>
                <option value='Europe'>Europe</option>
                <option value='Americas'>Americas</option>
                <option value='Oceania'>Oceania</option>
            </select>
        </div>
    </div>
  )
}

export default SearchContainer