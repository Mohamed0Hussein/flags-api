using FlagsApi.DTO;
using FlagsApi.Models;
using FlagsApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlagsApi.Services
{
    public class CountriesServices : ICountriesServices
    {
        private ICountriesRepository countriesRepository;

        public CountriesServices(ICountriesRepository countriesRepository) { 
            this.countriesRepository = countriesRepository;
        }

        public void AddMultipleCountries(List<CountryInsertDTO> countries)
        {

            var newCountries = new List<Country>();
            
            foreach (var country in countries)
            {
                var AltSpellings = new List<AltSpellings>();
                var Borders = new List<Border>();
                var CallingCodes = new List<CallingCodes>();
                var Timezones = new List<Timezones>();
                var TopLevelDomain = new List<TopLevelDomain>();
                var newCountry = new Country
                {
                    Name = country.Name,
                    Alpha2Code = country.Alpha2Code,
                    Alpha3Code = country.Alpha3Code,
                    Capital = country.Capital,
                    Subregion = country.Subregion,
                    Region = country.Region,
                    Population = country.Population,
                    Demonym = country.Demonym,
                    Area = country.Area,
                    NativeName = country.NativeName,
                    NumericCode = country.NumericCode,
                    Flag = country.Flag,
                    Currencies = country.Currencies,
                    Languages = country.Languages,
                    Translations = country.Translations,
                    RegionalBlocs = country.RegionalBlocs,
                    Cioc = country.Cioc,
                    Independent = country.Independent,
                    Latlng = country.Latlng.Count == 2 ? new Latlng { Lat = country.Latlng[0],Lng = country.Latlng[1] }: null,
                };
                foreach (var altSpelling in country.AltSpellings)
                {
                    AltSpellings.Add(new AltSpellings{ AltSpelling = altSpelling,Country=newCountry});
                }
                foreach(var border in country.Borders)
                {
                    Borders.Add(new Border { border = border, Country = newCountry});
                }
                foreach(var callCode in country.CallingCodes)
                {
                    CallingCodes.Add(new CallingCodes { CallingCode = callCode, Country = newCountry });
                }
                foreach(var timezone in country.Timezones)
                {
                    Timezones.Add(new Timezones{ timezones = timezone, Country = newCountry });
                }
                foreach(var topLevelDomain in country.TopLevelDomain)
                {
                    TopLevelDomain.Add(new TopLevelDomain { Name = topLevelDomain, Country = newCountry });
                }
                newCountry.TopLevelDomain = TopLevelDomain;
                newCountry.AltSpellings = AltSpellings;
                newCountry.Borders = Borders;
                newCountry.CallingCodes = CallingCodes;
                newCountry.Timezones = Timezones;
                newCountries.Add(newCountry);
            }
            countriesRepository.AddMultipleCountries(newCountries);
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return countriesRepository.GetCountries();
        }

        public List<Country> GetCountriesByQuery(int pageSize, int page, string name, string region)
        {
            return countriesRepository.GetCountriesByQuery(pageSize, page, name, region); 
        }


        public Country GetCountryById(int id)
        {
            return countriesRepository.GetCountryById(id);
        }

        public CountryDTO GetCountryAndBordersById(int id)
        {
            var Country = countriesRepository.GetCountryById(id);

            var dto = new CountryDTO
            {
                Alpha2Code = Country.Alpha2Code,
                Alpha3Code = Country.Alpha3Code,
                Name = Country.Name,
                AltSpellings = Country.AltSpellings,
                Area = Country.Area,
                Subregion = Country.Subregion,
                CallingCodes = Country.CallingCodes,
                Capital = Country.Capital,
                Cioc = Country.Cioc,
                Currencies = Country.Currencies,
                Id = id,
                NumericCode = Country.NumericCode,
                TopLevelDomain = Country.TopLevelDomain,
                Region = Country.Region,
                Population = Country.Population,
                Latlng = Country.Latlng,
                Demonym = Country.Demonym,
                Timezones = Country.Timezones,
                NativeName = Country.NativeName,
                Svg = Country.Flag.Svg,
                Png = Country.Flag.Png,
                Languages = Country.Languages,
                Translations = Country.Translations,
                RegionalBlocs = Country.RegionalBlocs,
                Independent = Country.Independent,
                BordersCountries = new List<string>()
            };
            foreach(var b  in Country.Borders)
            {
                var name = countriesRepository.GetCountryNameByAlphaCode3(b.border);
                dto.BordersCountries.Add(name);
            }

            return dto;
        }
    }
}
