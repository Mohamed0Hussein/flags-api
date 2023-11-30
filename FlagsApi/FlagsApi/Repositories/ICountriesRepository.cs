using FlagsApi.Models;

namespace FlagsApi.Repositories
{
    public interface ICountriesRepository 
    {
        IEnumerable<Country> GetCountries();
        void AddMultipleCountries(List<Country> countries);

        Country GetCountryById (int id);
        List<Country> GetCountriesByQuery(int pageSize,int page, string name, string region);
        Country Update(Country country);

        string GetCountryNameByAlphaCode3(string alphaCode3);

    }
}
