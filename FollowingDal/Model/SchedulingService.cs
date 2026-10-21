using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("SchedulingService")]
public partial class SchedulingService
{
    [Key]
    public int SchedulingServiceCode { get; set; }

    public int? JourneyCode { get; set; }

    public int? PassengerId { get; set; }

    public int? HotelServiceParticularCode { get; set; }

    public bool? TeamOrPassenger { get; set; }

    public int? StatusCode { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? BeginingTime { get; set; }

    public TimeOnly? EndTime { get; set; }
}
