using FollowingBl.Dto;
using FollowingDal.Model;
using FollowingDal.Repository;

namespace FollowingBl.Services
{
    public class CountryService(CountryRepository repository)
    {
        public async Task<List<CountryDto>> GetAllCountriesAsync()
        {
            var countries = await repository.GetAllCountryAsync();

            return countries.Select(c => new CountryDto
            {
                CountryCode = c.CountryCode,
                CountryNameHebrew = c.CountryNameHebrew,
                CountryNameEnglish = c.CountryNameEnglish,
            }).ToList();
        }

        public async Task<List<CityDto>> GetAllCitiesAsync()
        {
            var cities = await repository.GetAllCityAsync();

            return cities.Select(c => new CityDto
            {
                CityCode = c.CityCode,
                CountryCode = c.CountryCode,
                CityNameHebrew = c.CityNameHebrew,
                CityNameEnglish = c.CityNameEnglish,
            }).ToList();
        }

        public async Task<CityDto> AddCityAsync(CityDto cityDto)
        {
            var city = new City
            {
                CountryCode = cityDto.CountryCode,
                CityNameHebrew = cityDto.CityNameHebrew,
                CityNameEnglish = cityDto.CityNameEnglish
            };

            var result = await repository.AddCityAsync(city);
            cityDto.CityCode = result.CityCode;
            return cityDto;
        }

        public async Task<CountryDto> AddCountryAsync(CountryDto countryDto)
        {
            var country = new Country
            {
                CountryNameHebrew = countryDto.CountryNameHebrew,
                CountryNameEnglish = countryDto.CountryNameEnglish
            };

            var result = await repository.AddCountryAsync(country);
            countryDto.CountryCode = result.CountryCode;
            return countryDto;
        }
    }
}