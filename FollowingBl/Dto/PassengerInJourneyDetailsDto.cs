using FollowingDal.Model;

namespace FollowingBl.Dto;

internal class PassengerInJourneyDetailsDto
{
    public PassengerDto Passengers { get; set; }
    public PassengerInJourneyDto PassengersInJourney { get; set; }
}