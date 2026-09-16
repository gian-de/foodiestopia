using foodiestopia.DTOs.Country;

namespace foodiestopia.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAllCountriesAsync();
        Task<CountryDTO?> GetCountryBySlugAsync(string slug);
    }
}