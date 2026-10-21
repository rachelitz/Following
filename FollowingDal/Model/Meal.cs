using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Meal")]
public partial class Meal
{
    [Key]
    public int MealTypeCode { get; set; }

    [StringLength(50)]
    public string? MealTypeName { get; set; }
}
