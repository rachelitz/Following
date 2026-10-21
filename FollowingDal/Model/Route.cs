using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Route")]
public partial class Route
{
    [Key]
    public int RouteCode { get; set; }

    public int? JourneyCode { get; set; }

    public int? SiteCode { get; set; }

    public DateOnly? Date { get; set; }

    [Column(TypeName = "text")]
    public string? Comment { get; set; }

    public int? ChronologicalOrder { get; set; }

    public int? DayInWeek { get; set; }

    public TimeOnly? BeginningTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public int? StatusCode { get; set; }
}
