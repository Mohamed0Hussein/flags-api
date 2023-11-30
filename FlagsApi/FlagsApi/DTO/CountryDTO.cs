using FlagsApi.Models;

namespace FlagsApi.DTO
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TopLevelDomain>? TopLevelDomain { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public List<CallingCodes>? CallingCodes { get; set; }
        public string? Capital { get; set; }
        public List<AltSpellings>? AltSpellings { get; set; }
        public string? Subregion { get; set; }
        public string? Region { get; set; }
        public int? Population { get; set; }
        public Latlng? Latlng { get; set; }
        public string? Demonym { get; set; }
        public double? Area { get; set; }
        public List<Timezones>? Timezones { get; set; }
        public string? NativeName { get; set; }
        public string? NumericCode { get; set; }
        public string? Svg { get; set; }
        public string? Png { get; set; }
        public List<Currency>? Currencies { get; set; }
        public List<Language>? Languages { get; set; }
        public Translations? Translations { get; set; }
        public List<RegionalBloc>? RegionalBlocs { get; set; }
        public string? Cioc { get; set; }
        public bool? Independent { get; set; }
        public List<string> BordersCountries { get; set; }

    }
}
