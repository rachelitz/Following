using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("PassengerInJourney")]
public partial class PassengerInJourney
{
    [Key]
    public int PassengerInJournetCode { get; set; }

    public int? PassengerId { get; set; }

    public int? JourneyCode { get; set; }

    [StringLength(50)]
    public string? TypeInsurance { get; set; }

    public int? RationTypeCode { get; set; }

    [StringLength(50)]
    public string? TypeRoom { get; set; }

    public int? NumberInvitation { get; set; }

    public int? BeginningFlighCode { get; set; }

    public int? EndFlightCode { get; set; }

    public double? BeginningFlighCost { get; set; }

    public double? EndFlightCost { get; set; }
}
