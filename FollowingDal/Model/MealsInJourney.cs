using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("MealsInJourney")]
public partial class MealsInJourney
{
    [Key]
    public int MealInJourneyCode { get; set; }

    public int? JourneyCode { get; set; }

    public int? SchedulingMealCode { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? BeginningTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    [Column(TypeName = "text")]
    public string Comment { get; set; } = null!;
}
