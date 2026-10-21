using FollowingBl.Dto;
using FollowingBl.Services;
using Microsoft.AspNetCore.Mvc;

namespace FollowingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController(CountryService service) : ControllerBase
{

    [HttpGet("Countries")]
    public async Task<IActionResult> GetCountries()
    {
        var result = await service.GetAllCountriesAsync();
        return Ok(result);
    }

    [HttpGet("Cities")]
    public async Task<IActionResult> GetCities()
    {
        var result = await service.GetAllCitiesAsync();
        return Ok(result);
    }

    [HttpPost("AddCity")]
    public async Task<IActionResult> AddCity([FromBody] CityDto city)
    {
        var result = await service.AddCityAsync(city);
        return Created();
    }

    [HttpPost("AddCountry")]
    public async Task<IActionResult> AddCountry([FromBody] CountryDto country)
    {
        var result = await service.AddCountryAsync(country);
        return Created();
    }
}
