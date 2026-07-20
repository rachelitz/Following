using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

public partial class SchedulingMeal
{
    [Key]
    public int SchedulingMealCode { get; set; }

    public int? ServiceCateringTariffCode { get; set; }

    [StringLength(50)]
    public string? Level { get; set; }

    public int? DayInWeek { get; set; }
}
