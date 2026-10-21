using FollowingDal.Context;
using FollowingDal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FollowingDal.Repository
{
    public class PassengerRepository(FollowingDBContext context)
    {
        public async Task<List<Passenger>> GetAllPassengersAsync()
        {
            return await context.Passengers.ToListAsync();
        }
    }
}