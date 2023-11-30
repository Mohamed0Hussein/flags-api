using FlagsApi.Models;
using System.ComponentModel.DataAnnotations;

namespace FlagsApi.DTO
{
    public class CountryInsertDTO
    {
        public string Name { get; set; }
        public List<string>? TopLevelDomain { get; set; } = new();
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public List<string>? CallingCodes { get; set; } = new();
        public string? Capital { get; set; }
        public List<string>? AltSpellings { get; set; } = new();
        public string? Subregion { get; set; }
        public string? Region { get; set; }
        public int? Population { get; set; }
        public List<double>? Latlng { get; set; } = new();
        public string? Demonym { get; set; }
        public double? Area { get; set; }
        public List<string>? Timezones { get; set; } = new();
        public List<string>? Borders { get; set; } = new();
        public string? NativeName { get; set; }
        public string? NumericCode { get; set; }
        public Flag? Flag { get; set; }
        public List<Currency>? Currencies { get; set; }
        public List<Language>? Languages { get; set; }
        public Translations? Translations { get; set; }
        public List<RegionalBloc>? RegionalBlocs { get; set; }
        public string? Cioc { get; set; }
        public bool? Independent { get; set; }
    }
}
