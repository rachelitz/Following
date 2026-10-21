using FollowingBl.Services;
using FollowingDal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FollowingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PassengerController(PassengerService service) : ControllerBase
{
    [HttpGet("all")]
    public async Task<IActionResult> GetAllPassengers()
    {
        var result = await service.GetAllPassengersAsync();
        return Ok(result);
    }

    [HttpGet("byId/{id}")]
    public async Task<IActionResult> GetByIdAsync(int passengerId)
    {
        var result = await service.GetByIdAsync(passengerId);

        if (result == null) { return NotFound(); }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewPassenger([FromBody] PassengerDto passenger)
    {
        await service.AddNewPassenger(passenger);
        return Ok();
    }

    // QUERY: api/journey?statusCode=1&typeGroupCode=2

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int passengerId)
    {
        bool result = await service.DeleteAsync(passengerId);
        if (!result) { return NotFound(); }
        return Ok();
    }

    [HttpPost("InJourney")]
    public async Task<IActionResult> AddNewPassengerInJourney([FromBody] PassengerInJourneyDto passengerInJourney)
    {
        await service.AddNewPassengerInJourney(passengerInJourney);
        return Ok();
    }

    [HttpGet("PassengerInJourneyDetails")]
    public async Task<IActionResult> GetPassengersInJourneyDetails(int journeyCode)
    {
        var result = await service.GetPassengersInJourneyDetailsAsync(journeyCode);

        if (result == null) { return NotFound(); }
        return Ok(result);
    }

    [HttpGet("NumberOrderOfPartnerRoomById/{id}")]
    public async Task<IActionResult> GetNumberOrderOfPartnerRoomById(int partnerRoomId)
    {
        var result = await service.GetNumberOrderOfPartnerRoomByIdAsync(partnerRoomId);

        if (result == null) { return NotFound(); }
        return Ok(result);
    }
}