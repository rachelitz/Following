using FollowingBl.Dto;
using FollowingDal.Model;
using FollowingDal.Repository;

namespace FollowingBl.Services;

public class JourneyService(JourneyRepository repository)
{
    public async Task<List<JourneyDto>> GetAllJourneysAsync()
    {
        var journeys = await repository.GetAllJourneysAsync();

        return journeys.Select(j => new JourneyDto
        {
            JourneyCode = j.JourneyCode,
            JourneyName = j.JourneyName,
            //NumberOfPassengers = j.NumberOfPassengers,
            StatusCode = j.StatusCode,
            TypeGroupCode = j.TypeGroupCode,
            EndDate = j.EndDate,
            //CurrencyPricing = j.CurrencyPricing,
            CountryCode = j.CountryCode,
            BuisnessCustomersCode = j.BuisnessCustomersCode,
            BeginningDate = j.BeginningDate,
            BeginningFlighCode = j.BeginningFlighCode,
            EndFlighCode = j.EndFlighCode
        }).ToList();
    }

    public async Task<JourneyDto?> GetByIdAsync(int journeyId)
    {
        var journey = await repository.GetByIdAsync(journeyId);
        if (journey == null)
        {
            return null;
        }
        return new JourneyDto
        {
            JourneyCode = journey.JourneyCode,
            JourneyName = journey.JourneyName,
            StatusCode = journey.StatusCode,
            TypeGroupCode = journey.TypeGroupCode,
            EndDate = journey.EndDate,
            CountryCode = journey.CountryCode,
            BuisnessCustomersCode = journey.BuisnessCustomersCode,
            BeginningDate = journey.BeginningDate,
            BeginningFlighCode = journey.BeginningFlighCode,
            EndFlighCode = journey.EndFlighCode
        };
    }

    public async Task AddAsync(Journey journey)
    {
        await repository.AddAsync(journey);
    }

    public async Task<bool> DeleteAsync(int journeyId)
    {
        var journey = await repository.GetByIdAsync(journeyId);
        if (journey == null)
        {
            return false;
        }
        await repository.DeleteAsync(journey);
        return true;
    }
}