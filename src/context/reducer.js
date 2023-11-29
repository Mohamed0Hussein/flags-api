import {COUNTRY_CHANGED, FINISHED_FETCHING, REGION_CHANGED, SEARCH_NAME_CHANGED, START_FETCHING, TOGGLE_DARK_MODE, VALUES_RETURNED} from './actions'
const reducer = (state,action) => {
  if(action.type === START_FETCHING){
    return {
        ...state,
        isLoading:true,
        currentCountry:{}
    }
  }
  if(action.type === FINISHED_FETCHING){
    return{
        ...state,
        isLoading:false
    }
  }
  if(action.type === VALUES_RETURNED){
    return{
        ...state,
        isLoading:false,
        currentCountries: action.payload,
        currentCountry:{}
    }
  }
  if(action.type === REGION_CHANGED){
    return{
        ...state,
        isLoading:true,
        region:action.payload
    }
  }
  if(action.type === SEARCH_NAME_CHANGED){
    return{
        ...state,
        isLoading:true,
        name:action.payload
    }
  }
  if(action.type === COUNTRY_CHANGED){
    return{
      ...state,
      isLoading:false,
      currentCountry : action.payload
    }
  }
  if(action.type === TOGGLE_DARK_MODE){
    return{
      ...state,
      darkMode : !state.darkMode,
    }
  }
}

export default reducer