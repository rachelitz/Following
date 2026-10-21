using FollowingDal.Context;
using FollowingDal.Model;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Repository;

public class JourneyRepository(FollowingDBContext context)
{
    public async Task<List<Journey>> GetAllJourneysAsync()
    {
        return await context.Journeys.ToListAsync();
    }

    public async Task<Journey?> GetByIdAsync(int journeyId)
    {
        return await context.Journeys.FindAsync(journeyId);
    }

    public async Task AddAsync(Journey journey)
    {
        context.Journeys.Add(journey);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Journey journey)
    {
        context.Journeys.Remove(journey);
        await context.SaveChangesAsync();
    }
}