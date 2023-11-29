import {Landing,CountryPreview} from "./Pages";
import { AppProvider } from "./context/appContext";
import { Route,BrowserRouter as Router,Routes } from "react-router-dom";
function App() { 
  return (
    <AppProvider>
      <Router>
        <Routes> 
          <Route  path="/" element={<Landing/>}/>
          <Route  path="/Country_Preview" element={<CountryPreview/>}/>
        </Routes>
      </Router>
    </AppProvider>
  );
}

export default App;
