using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("TeamInJourney")]
public partial class TeamInJourney
{
    [Key]
    public int TeamInJourneyCode { get; set; }

    public int? EmployeeId { get; set; }

    public int? JourneyCode { get; set; }

    public double? CostToDay { get; set; }

    [StringLength(50)]
    public string? RoomType { get; set; }

    public bool? LocalOrNotLocal { get; set; }

    public DateOnly? StayFromDate { get; set; }

    public DateOnly? StayUntilDate { get; set; }

    public double? WageExtension { get; set; }

    public int? BeginningFlighCode { get; set; }

    public int? EndFlighCode { get; set; }

    public int? CurencyCode { get; set; }

    public double? BeginningFlighCost { get; set; }

    public double? EndFlighCost { get; set; }
}
