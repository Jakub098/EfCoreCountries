using CountryApp.DTO.Responses;
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
        public async Task<IActionResult> getCountries()
        {
            return Ok(await _countryService.GetCountries());
        }

        [HttpGet]
        public async Task<IEnumerable<CountryResponse>> getCountries2()
        {
            return await _countryService.GetCountries();
        }

    }
}
