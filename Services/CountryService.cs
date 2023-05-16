using CountryApp.DTO.Responses;
using CountryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly MyProjectContext _projectContext;

        public CountryService()
        {
            _projectContext = new MyProjectContext();
        }

        public Task<int> DeleteCountry(int idCountry)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CountryResponse>> GetCountries()
        {
            //Get all data from database
            var allData = await _projectContext.Countries
                .ToListAsync();


            //Create correct form
            var result = new List<CountryResponse>();
            foreach (var country in allData)
            {
                result.Add(new CountryResponse
                {
                    IdCountry = country.Id,
                    CountryName = country.Name
                });
            }
            return result;
        }
    }
}
