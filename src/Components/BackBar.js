import React from 'react'
import {IoIosArrowRoundBack } from 'react-icons/io'
import { useNavigate } from 'react-router-dom'
import { useAppContext } from '../context/appContext'

const BackBar = () => {
  const nav = useNavigate()
  const {darkMode} = useAppContext()
  return (
    <div className={`ml-10 shadow-sm shadow-black pt-2 px-5 rounded w-max ${darkMode ? `bg-[#202d36] text-white` : ``}`}>
            <button className='' onClick={() => {nav(-1)}}>
            <span className=' flex flex-row'>
                <IoIosArrowRoundBack className='-mb-1' size={'28px'}/>
                <p>Back</p>
            </span>
            </button>
        </div>
  )
}

export default BackBar