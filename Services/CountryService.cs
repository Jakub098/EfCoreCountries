using CountryApp.DTO.Responses;
using CountryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApp.Services
{
    public class CountryService : ICountryService
    {

        public Task<int> DeleteCountry(int idCountry)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CountryResponse>> GetCountryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
