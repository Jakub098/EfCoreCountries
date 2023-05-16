using CountryApp.DTO.Responses;
using Microsoft.EntityFrameworkCore;

namespace CountryApp.Services
{
    public interface ICountryService
    {
        public Task<IEnumerable<CountryResponse>> GetCountryAsync();
        public Task<int> DeleteCountry(int idCountry);
    }
}
