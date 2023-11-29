import React, { useReducer, useContext } from 'react';
import reducer from './reducer';
import axios from 'axios'
import {COUNTRY_CHANGED, REGION_CHANGED, SEARCH_NAME_CHANGED, TOGGLE_DARK_MODE, VALUES_RETURNED} from './actions';
const initialState = {
    isLoading : false,
    page: 1,
    region : '',
    currentCountries:[],
    pageSize : 12,
    skip : 0,
    name:'',
    currentCountry:{},
    darkMode : false
};

const AppContext = React.createContext();

axios.defaults.baseURL = '/api/Countries'

const AppProvider = ({ children }) => {
    const [state, dispatch] = useReducer(reducer, initialState);

    async function fetch(){
        try{
            const res = await axios.get(`GetCountriesByQuery?pageSize=${state.pageSize}&page=${state.page}&${state.name === '' ? "" : `name=${state.name}`}&${state.region === '' ? '' : `region=${state.region}`}`)
            dispatch({
                type:VALUES_RETURNED,
                payload:res.data
            })
        }
        catch(e){
            console.error(e)
        }
    }
    function regionChanged(newRegion){
        dispatch({
            type:REGION_CHANGED,
            payload:newRegion
        })
    }
    function nameChanged(newName){
        dispatch({
            type:SEARCH_NAME_CHANGED,
            payload:newName
        })
    }

    async function fetchById(id){
        const res = await axios.get(`GetCounrtyDetails?id=${id}`)
        dispatch({
            type:COUNTRY_CHANGED,
            payload:res.data
        })
    }
    function toggleDarkMode(){
        dispatch({
            type:TOGGLE_DARK_MODE
        })
    }
    return (
        <AppContext.Provider
            value={{
            ...state,
            fetch,
            regionChanged,
            nameChanged,
            fetchById,
            toggleDarkMode
            }}>
            {children}
        </AppContext.Provider>
        );
    };

const useAppContext = () => {
  return useContext(AppContext);
};

export { AppProvider, initialState, useAppContext };
