using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Flight")]
public partial class Flight
{
    [Key]
    public int FlightCode { get; set; }

    public TimeOnly? TakeoffTime { get; set; }

    public TimeOnly? LandingTime { get; set; }

    [StringLength(50)]
    public string? SourceTerminal { get; set; }

    [StringLength(50)]
    public string? DestinationTerminal { get; set; }

    public int? SourceCountryCode { get; set; }

    public int? DestinationCountryCode { get; set; }

    public int? CityCode { get; set; }

    public double? FlightCost { get; set; }

    public DateOnly? FlightDate { get; set; }

    public int? AirlineCode { get; set; }
}
