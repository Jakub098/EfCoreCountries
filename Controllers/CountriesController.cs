using CountryApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountryApp.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult getCountries()
        {
            return Ok(_countryService.GetCountries());
        }

    }
}
