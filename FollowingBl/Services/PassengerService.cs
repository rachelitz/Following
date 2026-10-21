using FollowingDal.Repository;

namespace FollowingBl.Services
{
    public class PassengerService(PassengerRepository repository)
    {
        public async Task<List<PassengerDto>> GetAllPassengersAsync()
        {
            var passengers = await repository.GetAllPassengersAsync();
            return passengers.Select(p => new PassengerDto
            {
                PassengerId = p.PassengerId,
                HebrewFirstNamePassenger = p.HebrewFirstNamePassenger,
                EnglishFirstNamePassenger = p.EnglishFirstNamePassenger,
                HebrewLastNamePassenger = p.HebrewLastNamePassenger,
                EnglishLastNamePassenger = p.EnglishLastNamePassenger,
                Mail = p.Mail,
                Phone = p.Phone,
                Gender = p.Gender ?? false
            }).ToList();
        }
    }
}