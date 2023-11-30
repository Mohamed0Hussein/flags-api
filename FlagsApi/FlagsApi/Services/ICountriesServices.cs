using FlagsApi.DTO;
using FlagsApi.Models;

namespace FlagsApi.Services
{
    public interface ICountriesServices
    {        
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int id);
        void AddMultipleCountries(List<CountryInsertDTO> countries);
        List<Country> GetCountriesByQuery(int pageSize, int page, string name, string region);
        CountryDTO GetCountryAndBordersById(int id);
    }
}
