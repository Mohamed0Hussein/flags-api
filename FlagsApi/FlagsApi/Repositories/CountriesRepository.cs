using FlagsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FlagsApi.Repositories
{
    public class CountriesRepository : ICountriesRepository
    {
        private readonly FlagsDBContext dbContext;

        public CountriesRepository(FlagsDBContext dbContext) { 
        
            this.dbContext = dbContext;
        }


        public void AddMultipleCountries(List<Country> countries)
        {
            dbContext.Countries.AddRange(countries);
            dbContext.SaveChanges();
            
        }
        
        public IEnumerable<Country> GetCountries()
        {
            return dbContext.Countries;
        }

        public List<Country> GetCountriesByQuery(int pageSize,int page, string name = "", string region = "")
        {
            var skip = pageSize * (page - 1);
            var query = dbContext.Countries.Where(c => c.Name.Contains(name) || name.IsNullOrEmpty()).Where(c => c.Region == region || region.IsNullOrEmpty()).Include(e => e.Flag).Skip(skip).Take(pageSize).ToList();

            return query;
        }

        public Country GetCountryById(int id)
        {
            /* return dbContext.Countries.Include(b => b.Borders).Include(e => e.Flag).Include(e => e.TopLevelDomain).Include(e => e.CallingCodes)
                 .Include(e => e.AltSpellings).Include(e => e.Latlng).Include(e => e.Timezones).Include(e => e.Currencies).Include(e => e.Languages).Include(e => e.Translations)
                 .Include(e => e.RegionalBlocs).FirstOrDefault(x => x.Id == id);*/
            return dbContext.Countries.Include(b => b.Borders).Include(e => e.Flag).Include(c => c.TopLevelDomain).Include(c => c.Currencies).Include(c => c.Languages).FirstOrDefault(x => x.Id == id);
        }

        public string GetCountryNameByAlphaCode3(string alphaCode3)
        {
            return dbContext.Countries.FirstOrDefault(c => c.Alpha3Code == alphaCode3).Name;
        }

        public Country Update(Country country)
        {
            var UpdatedCountry = dbContext.Countries.Update(country).Entity;
            dbContext.SaveChanges();
            return UpdatedCountry;

        }
    }
}
