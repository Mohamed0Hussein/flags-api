using FlagsApi.DTO;
using FlagsApi.Models;
using FlagsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlagsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private ICountriesServices countriesService;

        public CountriesController(ICountriesServices countriesService)
        {
            this.countriesService = countriesService;
        }

        [HttpPost]
        public void AddMultiple(List<CountryInsertDTO> countries)
        {
            countriesService.AddMultipleCountries(countries);
        }
        [HttpGet]
        public List<Country> GetCountriesByQuery([FromQuery] int pageSize, [FromQuery] int page, [FromQuery] string name = "", [FromQuery] string region = "")
        {
            return countriesService.GetCountriesByQuery(pageSize, page, name, region);
        }
        [HttpGet]
        public CountryDTO GetCounrtyDetails([FromQuery] int id) 
        {
            return countriesService.GetCountryAndBordersById(id);
        }

    }
}
